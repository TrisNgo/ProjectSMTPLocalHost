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
using System.Diagnostics;

namespace ProjectSMTPLocalHost
{
    public partial class FrmSmtpLocal : Form
    {
        TcpClient tcpClient;
        IPAddress iPAddress;
        IPEndPoint iPEndPoint;
        //khởi tạo 2 thread
        Thread authenThd;
        Thread listenThd;

        StreamReader sr;
        StreamWriter sw;

        long time;

        //Biến global isAuthen dùng để kiểm tra việc xác thực có Ok không
        //Biến stop dùng để ra tính hiệu cho việc ngừng thread
        bool isAuthen = true;
        bool stop = false;
        int count = 0;
        string[] filePath = new string[10];
        int index = 0;
        string[] fileName = new string[10];

        public FrmSmtpLocal()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        private string inforToBase64(string input)
        {
            byte[] inputToBytes = System.Text.ASCIIEncoding.UTF8.GetBytes(input);
            string encodedInput = System.Convert.ToBase64String(inputToBytes);
            return encodedInput;
        }

        private string fileToBase64(string path)
        {
            Byte[] bytes = File.ReadAllBytes(path);
            String file = Convert.ToBase64String(bytes);
            return file;
        }

        private void addTextToBox2(string input)
        {
            string text = "C: " + input + "\n";
            txtBoxSendSer.Text += text;
        }

        //Authentication
        private void authenCheck(string input)
        {
            string text = "S: " + input + "\n";
            txtBoxGetSer.Text += text;
            string statusCode = input.Substring(0, 3);
            if ((Int32.Parse(statusCode) >= 500) && (Int32.Parse(statusCode) < 600))
            {
                stop = true;
                isAuthen = false;
                return;
            }
            else
            {
                count++;
            }
            if (comboBox1.SelectedIndex == 0 && count == 13) //if the server is using is mdaemon
            {
                stop = true;
                return;
            }
            else if (comboBox1.SelectedIndex == 1 && count == 10) //if the server is using is hmail
            {
                stop = true;
                return;
            }
            else if (comboBox1.SelectedIndex == 2 && count == 7) ////if the server is using is self-build server
            {
                stop = true;
                return;
            }
        }

        private void addTextToBox1(string input)
        {
            string text = "S: " + input + "\n";
            txtBoxGetSer.Text += text;
            if ((comboBox1.SelectedIndex == 2 && input.StartsWith("221")) || (comboBox1.SelectedIndex == 1 && input.StartsWith("354")) || (comboBox1.SelectedIndex == 0 && input.StartsWith("221")))
            {
                MessageBox.Show("Gửi mail thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string strFrom = txtBoxMailFrom.Text.Trim();
            string strTo = txtBoxMailTo.Text.Trim();
            //create regular express to find a char is NOT allow to contain in email(Ex: #$%..)
            Regex RgxEmail = new Regex("[^a-zA-Z0-9@._-]");
            if (string.IsNullOrEmpty(strFrom) || string.IsNullOrEmpty(strTo) || string.IsNullOrEmpty(txtBoxPwd.Text.Trim()))
            {
                MessageBox.Show("Chưa điền các thông tin tài khoản gửi và nhận. Nhập lại");
                return false;
            }
            else if (!strFrom.Contains('@') || !strTo.Contains('@') || RgxEmail.IsMatch(strFrom) || RgxEmail.IsMatch(strTo))
            {
                MessageBox.Show("Mail tài khoản gửi và nhận đã nhập sai. Nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void sendMess(string data)
        {
            sw.WriteLine(data);
            sw.Flush();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                filePath[index] = ofd.FileName;
                fileName[index] = ofd.SafeFileName;
                lblAttach.Text += " " + fileName[index];
                index++;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn file");
            }
        }

        private void bttnClrAttach_Click(object sender, EventArgs e)
        {
            Array.Clear(filePath, 0, filePath.Length);
            Array.Clear(fileName, 0, fileName.Length);
            lblAttach.Text = "Attachments:";
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

            //run thread to listen a reply from mailserver and also check authen correct or not from server
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                authenThd = new Thread(new ThreadStart(authenMess));
                authenThd.IsBackground = true;
                authenThd.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xuất hiện lỗi:" + ex.ToString(), " Không gửi mail được. Vui lòng thử lại sau", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //get mail domain
            int index = txtBoxMailFrom.Text.Trim().IndexOf('@');
            string domain = txtBoxMailFrom.Text.Trim().Substring(index + 1);
            try
            {
                //step to send mail
                string data = "EHLO " + domain;

                addTextToBox2(data);
                sendMess(data);

                data = "AUTH LOGIN";
                addTextToBox2(data);
                sendMess(data);

                data = inforToBase64(txtBoxMailFrom.Text);
                addTextToBox2(data);
                sendMess(data);

                data = inforToBase64(txtBoxPwd.Text);
                addTextToBox2(data);
                sendMess(data);


                data = "MAIL FROM:<" + txtBoxMailFrom.Text + ">";
                addTextToBox2(data);
                sendMess(data);

                data = "RCPT TO:<" + txtBoxMailTo.Text + ">";
                addTextToBox2(data);
                sendMess(data);

                //Wait for the authen to complete
                authenThd.Join();
                if (isAuthen)
                {
                    //nếu xác thực thành công mới gọi thread khác để nhận thông điệp tiếp
                    try
                    {
                        listenThd = new Thread(new ThreadStart(getMess));
                        listenThd.IsBackground = true;
                        listenThd.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xuất hiện lỗi:" + ex.ToString(), " Không gửi mail được. Vui lòng thử lại sau", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    data = "DATA";
                    addTextToBox2(data);
                    sendMess(data);

                    data = "FROM: =?utf-8?B?" + inforToBase64(txtBoxNameFrom.Text) + "?= <" + txtBoxMailFrom.Text + ">";
                    addTextToBox2(data);
                    sendMess(data);

                    data = "TO: =?utf-8?B?" + inforToBase64(txtBoxNameTo.Text) + "?= <" + txtBoxMailTo.Text + ">";
                    addTextToBox2(data);
                    sendMess(data);

                    data = "Subject: =?utf-8?B?" + inforToBase64(txtBoxSubject.Text) + "?=";
                    addTextToBox2(data);
                    sendMess(data);

                    data = "MIME-Version: 1.0";
                    addTextToBox2(data);
                    sendMess(data);

                    data = "Content-Type: multipart/mixed; boundary=\"boundary_ranh_gioi\"";
                    addTextToBox2(data);
                    sendMess(data);

                    addTextToBox2("");
                    sendMess("");

                    data = "--boundary_ranh_gioi";
                    addTextToBox2(data);
                    sendMess(data);

                    data = "Content-Type: text/plain; charset=\"UTF-8\"";
                    addTextToBox2(data);
                    sendMess(data);

                    data = "Content-Transfer-Encoding: base64";
                    addTextToBox2(data);
                    sendMess(data);

                    addTextToBox2("");
                    sendMess("");

                    data = richTBBody.Text;

                    addTextToBox2(data);
                    sendMess(inforToBase64(data));

                    addTextToBox2("");
                    sendMess("");

                    for (int i = 0; i < filePath.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(filePath[i]))
                        {
                            string path = filePath[i];
                            // attachment 1 file
                            data = "--boundary_ranh_gioi";
                            addTextToBox2(data);
                            sendMess(data);

                            data = "Content-Type: file --mime-type -b "+ fileName[i]+ "; name=" +fileName[i];
                            addTextToBox2(data);
                            sendMess(data);

                            data = "Content-Transfer-Encoding: base64";
                            addTextToBox2(data);
                            sendMess(data);

                            data = "Content-Disposition: attachment; filename=" + fileName[i];
                            addTextToBox2(data);
                            sendMess(data);

                            addTextToBox2("");
                            sendMess("");

                            addTextToBox2("Attachment - File: " + path);
                            sendMess(fileToBase64(path));

                            addTextToBox2("");
                            sendMess("");


                            data = "--boundary_ranh_gioi--";
                            addTextToBox2(data);
                            sendMess(data);
                        }
                    }

                    addTextToBox2(".");
                    sendMess(".");

                    data = "QUIT";
                    addTextToBox2(data);
                    sendMess(data);

                    // Wait for the server to complete the process. After that close all stream
                    listenThd.Join();
                }
                else
                {
                    MessageBox.Show("Xác thực không thành công, Mail không gửi được!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Set all the value to default, ready for the next action
                stop = false;
                isAuthen = true;
                count = 0;
                //if (authenThd.IsAlive) authenThd.Abort();
                sw.Close();
                sr.Close();
                tcpClient.Close();
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
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            //get reply message from mailserver
            while (true)
            {
                if (watch.ElapsedMilliseconds > 5000)
                {
                    time = watch.ElapsedMilliseconds;
                    MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra xem bạn đã chọn đúng loại server hay chưa! Việc chọn sai server bạn đang sử dụng có thể khiến cho chương trình không thể nhận chính xác phản hồi từ máy chủ!", "Lỗi");
                    isAuthen = false;
                    stop = true;
                }
                else
                {
                    string mess = "";
                    mess = sr.ReadLine();
                    if (string.IsNullOrEmpty(mess))//if server do not send any message(serverproblem) ,break it and stop thread, tcp connection
                    {
                        tcpClient.Close();
                        break;
                    }
                    authenCheck(mess);
                }
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
                if (string.IsNullOrEmpty(mess))//if server do not send any message(serverproblem) ,break it and stop thread, tcp connection
                {
                    tcpClient.Close();
                    break;
                }
                addTextToBox1(mess);
            }
        }
    }
}