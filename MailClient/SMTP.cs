using System;
using System.Collections.Generic;
using System.Text;

namespace MailClient
{
    class SMTP
    {
        MailAccount account;
        NetService net;
        string info;
        Object infolock;

        static string []codes = { "220", "250", "334", "235", "354", "221" };
        public static string suc = "成功";

        SMTP() { }

        public SMTP(MailAccount account)
        {
            this.account = account;
            info = "";
            infolock = new Object();
        }

        void setInfo(string str)
        {
            lock (infolock)
            {
                info = str;
            }
        }

        bool step(string cmd, string statuscode)
        {
            string res = "";
            while (!net.send(cmd)) ;
            while ("" == (res = net.getmsg())) ;
            string[] strs = res.Split(new char[] { ' ', '-' });
            if (strs[0] != statuscode)
            {
                setInfo(res);
                return false;
            }
            return true;
        }

        bool login()
        {
            string res = "";
            net = new NetService(account.Smtpadd, account.Smtpport);
            while ("" == (res = net.getmsg())) ;
            string[] strs = res.Split(new char[]{' ', '-'});
            if (strs[0] != codes[0])
            {
                setInfo(res);
                return false;
            }

            if (!step("EHLO " + account.Smtpadd + Mail.crlf, codes[1]))
                return false;

            if (!step("AUTH LOGIN" + Mail.crlf, codes[2]))
                return false;

            string u64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(account.Username));
            if (!step(u64 + Mail.crlf, codes[2]))
                return false;

            string p64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(account.Password));
            if (!step(p64 + Mail.crlf, codes[3]))
                return false;
        
            return true;
        }

        bool send(Mail mail)
        {
            if (!step("MAIL FROM:" + account.Username + Mail.crlf, codes[1]))
                return false;

            if (!step("RCPT TO:" + mail.To + Mail.crlf, codes[1]))
                return false;

            if (!step("DATA" + Mail.crlf, codes[4]))
                return false;

            if (!step(mail.toString(), codes[1]))
                return false;

            return true;
        }

        void quit()
        {
            net.send("QUIT" + Mail.crlf);
        }

        public void sendmail(Mail mail)
        {
            if (login() && send(mail))
                setInfo(suc);
            quit();
        }

        public string getInfo()
        {
            lock (infolock)
            {
                return info;
            }
        }
    }
}
