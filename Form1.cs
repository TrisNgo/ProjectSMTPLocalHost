using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;

namespace ProjectSMTPLocalHost
{
    public partial class FrmSmtpLocal : Form
    {
        TcpClient tcpClient;
        IPAddress iPAddress;
        IPEndPoint iPEndPoint;
        Thread authenThd;
        Thread listenThd;

        StreamReader sr;
        StreamWriter sw;

        //Biến global isAuthen dùng để kiểm tra việc xác thực có Ok không
        //Biến stop dùng để ra tính hiệu cho việc ngừng thread
        bool isAuthen = true;
        bool stop = false;

        public FrmSmtpLocal()
        {
            InitializeComponent();
        }
        private string inforToBase64(string input)
        {
            byte[] inputToBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(input);
            string encodedInput = System.Convert.ToBase64String(inputToBytes);
            return encodedInput;
        }

        private void addTextToBox2(string input)
        {
            string text = "C: " + input + "\n";
            txtBoxSendSer.Text += text;
        }


        private void authenCheck(string input)
        {
            string text = "S: " + input + "\n";
            txtBoxGetSer.Text += text;
            if (input.Contains("Authentication"))
            {
                if (input.Contains("failed") || input.Contains("invalid") || input.Contains("Bad") || input.Contains("Unrecognized") || input.Contains("required"))
                {

                    stop = true;
                    isAuthen = false;
                }
            }
            else if ((input.Contains("Sender") && stop != true))
            {
                if (input.Contains("unknown"))
                {
                    isAuthen = false;
                    stop = true;
                }
            }
            else if ((input.Contains("Recipient") && stop != true))
            {
                if (input.Contains("unknown"))
                {
                    isAuthen = false;
                }
                //Điều kiện Recipient được kiểm tra cuối cùng nên cho dù có hợp lệ hay không thì stop vẫn phải bằng true để dừng lại
                stop = true;
            }

        }

        private void addTextToBox1(string input)
        {
            string text = "S: " + input + "\n";
            txtBoxGetSer.Text += text;
            if (input.Contains("saved"))
            {
                MessageBox.Show("Gửi mail thành công", "Thông báo");
                listenThd.Abort();
            }
        }
        //use to hide and show password. Password is auto hide by default using property UseSystemPasswordChar = true
        private void checkBoxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPwd.Checked)
            {
                txtBoxPwd.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPwd.UseSystemPasswordChar = true;
            }
        }
        private bool checkAccounts()
        {
            string strFrom = txtBoxFrom.Text.Trim();
            string strTo = txtBoxTo.Text.Trim();
            //create regular express to find a char is NOT allow to contain in email(Ex: #$%..)
            Regex RgxEmail = new Regex("[^a-zA-Z0-9@._-]");
            if (string.IsNullOrEmpty(strFrom) || string.IsNullOrEmpty(strTo) || string.IsNullOrEmpty(txtBoxPwd.Text.Trim()))
            {
                MessageBox.Show("Chưa điền các thông tin tài khoản gửi và nhận. Nhập lại");
                return false;
            }
            else if (!strFrom.Contains('@') || !strTo.Contains('@') || RgxEmail.IsMatch(strFrom) || RgxEmail.IsMatch(strTo))
            {
                MessageBox.Show("Mail tài khoản gửi và nhận đã nhập sai. Nhập lại");
                return false;
            }
            return true;
        }

        private void sendMess(string data)
        {
            sw.WriteLine(data);
            sw.Flush();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //if txtBoxSendSer and txtBoxGetSer have already text on previous sending, clear it
            txtBoxGetSer.Clear();
            txtBoxSendSer.Clear();
            //check information send and receive
            if (!checkAccounts())
                return;

            //setup connection
            tcpClient = new TcpClient();
            iPAddress = IPAddress.Parse("127.0.0.1");
            iPEndPoint = new IPEndPoint(iPAddress, 25);
            tcpClient.Connect(iPEndPoint);

            sr = new StreamReader(tcpClient.GetStream());
            sw = new StreamWriter(tcpClient.GetStream());

            //run thread to listen a reply from mailserver
            CheckForIllegalCrossThreadCalls = false;
            authenThd = new Thread(new ThreadStart(authenMess));
            authenThd.IsBackground = true;
            authenThd.Start();
            //get mail domain
            int index = txtBoxFrom.Text.Trim().IndexOf('@');
            string domain = txtBoxFrom.Text.Trim().Substring(index + 1);
            try
            {
                //step to send mail
                string data = "EHLO " + domain;

                addTextToBox2(data);
                sendMess(data);

                data = "AUTH LOGIN";
                addTextToBox2(data);
                sendMess(data);

                data = inforToBase64(txtBoxFrom.Text);
                addTextToBox2(data);
                sendMess(data);

                data = inforToBase64(txtBoxPwd.Text);
                addTextToBox2(data);
                sendMess(data);



                data = "MAIL FROM:<" + txtBoxFrom.Text + ">";
                addTextToBox2(data);
                sendMess(data);

                data = "RCPT TO:<" + txtBoxTo.Text + ">";
                addTextToBox2(data);
                sendMess(data);

                //Đợi việc xác thực xong mới gửi mail
                authenThd.Join();
                if (isAuthen)
                {
                    listenThd = new Thread(new ThreadStart(getMess));
                    listenThd.IsBackground = true;
                    listenThd.Start();

                    data = "DATA";
                    addTextToBox2(data);
                    sendMess(data);

                    data = "FROM:<" + txtBoxFrom.Text + ">";
                    addTextToBox2(data);
                    sendMess(data);

                    data = "TO:<" + txtBoxTo.Text + ">";
                    addTextToBox2(data);
                    sendMess(data);

                    data = "Content-Type: text/plain; charset=\"UTF-8\"";//this make Vietnamese mail can be sent
                    addTextToBox2(data);
                    sendMess(data);

                    data = "subject: " + txtBoxSubject.Text;
                    addTextToBox2(data);
                    sendMess(data);

                    addTextToBox2("");
                    sendMess("");
                    data = richTBBody.Text;

                    if (data.Contains("\n"))
                    {
                        string[] newData = data.Split('\n');
                        foreach (string stringLine in newData)
                        {
                            addTextToBox2(stringLine);
                            sendMess(stringLine);
                        }
                    }
                    else
                    {
                        addTextToBox2(data);
                        sendMess(data);
                    }
                    addTextToBox2("");
                    sendMess("");

                    addTextToBox2(".");
                    sendMess(".");

                    data = "QUIT";
                    addTextToBox2(data);
                    sendMess(data);

                    //Đợi máy chủ trả về kết quả xong, tránh trường hợp máy chủ chưa trả về xong mà xuống dưới đã đóng Stream
                    listenThd.Join();
                }
                else
                {
                    MessageBox.Show("Xác thực không thành công, Mail không gửi được!", "Lỗi xác thực");
                }

                //Cho các giá trị về mặc định để chuẩn bị cho lần gửi mail tiếp theo
                stop = false;
                isAuthen = true;
                authenThd.Abort();
                sw.Close();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chi tiết kỹ thuật:" + ex.ToString(), "Xuất hiện lỗi. Không gửi mail được. Vui lòng thử lại sau", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Hàm kiểm tra xem server có xác thực được thông tin của user không
        private void authenMess()
        {
            //get reply message from mailserver
            while (true)
            {
                string mess = "";
                mess = sr.ReadLine();
                if (string.IsNullOrEmpty(mess))
                {
                    tcpClient.Close();
                    break;
                }
                authenCheck(mess);
                if (stop == true) break;
            }
        }

        private void getMess()
        {
            //get reply message from mailserver
            while (true)
            {
                string mess = "";
                mess = sr.ReadLine();
                if (string.IsNullOrEmpty(mess))
                {
                    tcpClient.Close();
                    break;
                }
                addTextToBox1(mess);
            }
        }

    }
}
