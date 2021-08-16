using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SMTPServer
{
    //Class dùng để chứa dữ liệu của mail người dùng
    public class SMTPMessage
    {
        public string From;
        public List<string> To = new List<string>();
        public List<string> Data = new List<string>();

        //Ghi mail ra tệp
        //Do mail được gửi theo chuẩn MINE 1.0 nên mail lưu ra file sẽ có nội dung ở dạng mã hóa
        //Nếu có server thật như outlook thì server sẽ tự hiểu và chuyển sang plaintext
        public void Save()
        {
            DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            string time = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            time = time.Replace(':', '-');
            time = time.Replace(' ', '-');
            string fileName = @"" + directory + "\\SavedMails\\" + time + "_mail.smtp";
            File.WriteAllText(fileName, From + "\r\n");
            File.AppendAllLines(fileName, To);
            File.AppendAllLines(fileName, Data);
        }
    }
}
