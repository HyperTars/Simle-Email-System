using System;
using System.Collections.Generic;
using System.Text;

namespace MailClient
{
    class Mail
    {
        string subject;
        string date;
        string from;
        string content;
        string to;
        int id;

        public static char []cr_lf = { (char)13, (char)10 };
        public static string crlf = new string(cr_lf);
        public static string mailend = crlf + "." + crlf;

        public string Subject { get => subject; set => subject = value; }
        public string Date { get => date; set => date = value; }
        public string From { get => from; set => from = value; }
        public string Content { get => content; set => content = value; }
        public int Id { get => id; set => id = value; }
        public string To { get => to; set => to = value; }

        Mail() { }

        string getattri(string attri, string str)
        {
            string ans = "";

            int pos = str.IndexOf(attri);
            if (pos == -1)
                return ans;
            pos += attri.Length;

            while (str.Substring(pos, 2) != crlf)
                ans += str[pos++];
            return ans;
        }

        public Mail(string str)
        {
            subject = getattri("Subject: ", str);
            date = getattri("Date: ", str);
            from = getattri("From: ", str);

            int pos = str.IndexOf(crlf+crlf);
            pos += 4;
            content = "";
            while (str.Substring(pos, 5) != crlf + "." + crlf)
                content += str[pos++];
        }

        public Mail(string to, string subject, string content)
        {
            this.subject = subject;
            this.content = content;
            this.to = to;
        }

        public string toString()
        {
            return "Subject: " + subject + crlf + content + mailend;
        }
    }
}
