using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SMTPServer
{
    public class SMTP
    {
        //Tách mail từ các câu lệnh do người dùng gửi lên server
        public static string[] getMailsFromText(string text)
        {
            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*",
            RegexOptions.IgnoreCase);
            MatchCollection emailMatches = emailRegex.Matches(text);
            List<string> result = new List<string>();
            foreach (Match emailMatch in emailMatches)
                result.Add(emailMatch.Value);
            return result.ToArray();
        }


        //Kiểm tra xem mail của người gửi hoặc người nhận có hợp lệ không
        public static bool checkIfEmailsIsInternal(string text)
        {
            //Lấy mail của người gửi hoặc danh sách các người nhận trong trường hợp có nhiều người nhận
            string[] mails = getMailsFromText(text);
            //Kiểm tra xem mail này có phải là mail hợp lệ không (mail trong cùng 1 domain)
            foreach (string mail in mails)
                if (!isInternal(mail))
                    return false;
            return true;
        }

        //Vì đây là server mô phỏng việc gửi mail cục bộ nên ta phải kiểm tra xem tên domain có hợp lệ không
        public static bool isInternal(string email)
        {
            if (email.EndsWith("@nhom8.nt106"))
                return true;
            return false;
        }

    }
}
