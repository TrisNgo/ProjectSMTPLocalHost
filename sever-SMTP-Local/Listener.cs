using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections;
using System.Net;
using System.Net.Sockets;

namespace SMTPServer
{
    //Class thực hiện việc lắng nghe và phản hồi người dùng
    public class Listener
    {
        System.IO.StreamReader reader;
        System.IO.StreamWriter writer;
        TcpClient client;

        public Listener(TcpClient client)
        {
            this.client = client;
            NetworkStream stream = client.GetStream();
            reader = new System.IO.StreamReader(stream);
            writer = new System.IO.StreamWriter(stream);
            writer.NewLine = "\r\n";
            writer.AutoFlush = true;
        }
        public static void Start()
        {
            //Thiết lập địa chỉ ip và cổng kết nối cho server
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 1024);
            listener.Start();
            while (true)
            {
                Listener handler = new Listener(listener.AcceptTcpClient());
                Thread thread = new System.Threading.Thread(new ThreadStart(handler.Run));
                thread.Start();
            }
        }

        public void Run()
        {
            try
            {
                writeToClient(220, "Nhom8 NT106.L21.ATCL SMTP Server");
                SMTPMessage message = new SMTPMessage();
                bool isUserAuthenticated = false;
                while (true)
                {
                    string line = readFromClient();
                    if (line == null)
                        break;
                    //Lấy mã của các câu lệnh người dùng gửi lên
                    string[] tokens = line.Split(' ');
                    bool requiresAuthorization = false;
                    //Trả về phản hồi tùy theo câu lệnh người dùng gửi
                    switch (tokens[0].ToUpper())
                    {
                        case "EHLO":
                            {
                                writeToClient(250, "127.0.0.1 SMTP Server");
                                break;
                            }
                        case "HELP":
                            {
                                writeToClient(250, "OK Success - please contact admin for more information");
                                break;
                            }
                        case "HELO":
                            {
                                writeToClient(250, "OK Success");
                                break;
                            }
                        case "MAIL":
                            {
                                //Kiểm tra xem người gửi có phải là người trong cùng 1 domain không
                                if (SMTP.checkIfEmailsIsInternal(line))
                                    requiresAuthorization = true;
                                //Nếu cùng domain mà chưa đăng nhập thì báo lỗi
                                if (requiresAuthorization && !isUserAuthenticated)
                                {
                                    writeToClient(530, "Authorization required");
                                    break;
                                }
                                message.From = line;
                                writeToClient(250, "OK Success");
                                break;
                            }
                        case "RCPT":
                            {
                                //Kiểm tra xem người nhận có phải cùng domain không
                                if (SMTP.checkIfEmailsIsInternal(line))
                                {
                                    requiresAuthorization = true;
                                }
                                if (requiresAuthorization && !isUserAuthenticated)
                                {
                                    writeToClient(530, "Authorization required");
                                    break;
                                }
                                message.To.Add(line);
                                writeToClient(250, "OK ");
                                break;
                            }
                        case "AUTH":
                            {
                                writeToClient(334, "VXNlcm5hbWU6");
                                string user = readBase64();
                                if (user == null)
                                    return;
                                if (user.Length == 0)
                                {
                                    writeToClient(535, "invalid user");
                                    break;
                                }
                                writeToClient(334, "UGFzc3dvcmQ6");
                                string pass = readBase64();
                                if (pass == null)
                                    return;
                                if (pass.Length == 0)
                                {
                                    writeToClient(535, "invalid password");
                                }
                                // Mô phỏng dữ liệu trong database bằng cách lưu tài khoản mật khẩu vào file text sau đó truy xuất
                                /* Các tài khoản mật khẩu hợp lệ
                                user1@nhom8.nt106-nhom8
                                user2@nhom8.nt106-nhom8
                                user3@nhom8.nt106-nhom8
                                user4@nhom8.nt016-nhom8
                                */
                                //Chỉnh sửa tài khoản mật khẩu bằng cách chỉnh sửa file database.txt trong thư mục bin\debug\
                                string[] informations = File.ReadAllLines("database.txt");
                                bool isValid = false;
                                //Kiểm tra xem tài khoản mật khẩu người dùng nhập có hợp lệ không
                                foreach (string information in informations)
                                {
                                    string[] data = information.Split('-');
                                    if (data[0] == user && base64Decode(data[1]) == pass)
                                    {
                                        isValid = true;
                                        break;
                                    }
                                }
                                if (!isValid)
                                {
                                    writeToClient(535, "Authentication failed");
                                    break;
                                }
                                //Nếu hợp lệ thì thông báo cho người dùng
                                isUserAuthenticated = true;
                                writeToClient(235, "Authentication succesful");
                                break;
                            }
                        case "DATA":
                            {
                                if (requiresAuthorization && !isUserAuthenticated)
                                {
                                    writeToClient(530, "Authorization Required");
                                    break;
                                }
                                writeToClient(354, "End data with <CR><LF>.<CR><LF>");
                                message.Data.Add(line);
                                for (; ; )
                                {
                                    line = readFromClient();
                                    message.Data.Add(line);
                                    if ((line == null) || (line == "."))
                                        break;
                                }
                                writeToClient(250, "OK: queued");
                                message.Save();
                                message = new SMTPMessage();
                                break;
                            }
                        case "RSET":
                            {
                                writeToClient(250, "OK: Reset");
                                message = new SMTPMessage();
                                break;
                            }
                        case "QUIT":
                            {
                                writeToClient(221, "BYE");
                                writer.Close();
                                client.Close();
                                return;
                            }
                        default:
                            writeToClient(550, "Command not understood");
                            break;
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        private void writeToClient(int code, string c)
        {
            writer.WriteLine(code + " " + c);
            writer.Flush();
            Console.WriteLine(">> " + code + " " + c);
            Console.WriteLine();
        }

        private string readFromClient()
        {
            string result = null;
            try
            {
                result = reader.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            if (result == null)
                Console.WriteLine("<< NULL");
            else
                Console.WriteLine("<< " + result);
            return result;
        }

        //Decode base 64 từ client gửi lên
        private string readBase64()
        {
            try
            {
                string record = readFromClient();
                if (record == null)
                    return null;
                return System.Text.Encoding.ASCII.GetString(Convert.FromBase64String(record));
            }
            catch (Exception)
            {
                return "";
            }
        }

        //Decode base64 từ file database.txt
        public string base64Decode(string input)
        {
            byte[] base64EncodedBytes = System.Convert.FromBase64String(input);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }
}
