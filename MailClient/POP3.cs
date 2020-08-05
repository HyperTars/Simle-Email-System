using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace MailClient
{
    class POP3
    {
        ArrayList mails;
        MailAccount account;
        NetService net;
        string info;
        Object infolock;

        string[] errs = { "服务器响应错误", "用户名错误", "用户名或密码错误" };
        public string suc = "成功";

        POP3() { }

        public POP3(MailAccount account)
        {
            this.account = account;
            mails = new ArrayList();
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

        string step(string cmd, string err)
        {
            string res = "";
            while (!net.send(cmd)) ;
            while ("" == (res = net.getmsg())) ;
            if (res[0] != '+')
                setInfo(err);
            return res;
        }

        bool login()
        {
            string res = "";
            net = new NetService(account.Pop3add, account.Pop3port);
            while ("" == (res = net.getmsg())) ;
            if (res[0] != '+')
            {
                setInfo(errs[0]);
                return false;
            }

            if (step("USER " + account.Username + Mail.crlf, errs[1])[0] != '+')
                return false;

            if (step("PASS " + account.Password + Mail.crlf, errs[2])[0] != '+')
                return false;

            return true;
        }

        bool recv()
        {
            string res = "";
            if ((res = step("LIST" + Mail.crlf, errs[0]))[0] != '+')
                return false;
            while (!res.Contains(Mail.mailend))
                res += net.getmsg();

            string []lis = res.Split(Mail.cr_lf, StringSplitOptions.RemoveEmptyEntries);
            int len = lis.Length;
            string[] id_size = lis[len - 2].Split(' ');

            int total = Convert.ToInt32(id_size[0]);
            for (int i = 1; i <= total; i++)
            {
                if ((res = step("RETR " + i.ToString() + Mail.crlf, errs[0]))[0] != '+')
                    return false;
                while (!res.Contains(Mail.mailend))
                    res += net.getmsg();

                Mail mail = new Mail(res);
                mail.Id = i-1;
                mails.Add(mail);
                System.Threading.Thread.Sleep(1);
            }
            return true;
        }

        bool delete(int id)
        {
            string res = "";
            if ((res = step("DELE " + id.ToString() + Mail.crlf, errs[0]))[0] != '+')
                return false;
            return true;
        }

        void quit()
        {
            net.send("QUIT"+Mail.crlf);
        }

        public void threadingRetrieve()
        {
            new System.Threading.Thread(retrieve).Start();
        }

        void retrieve()
        {
            mails.Clear();
            if (login() && recv())
                setInfo(suc);
            quit();
        }

        public void remove(int id)
        {
            if (login() && delete(id))
                setInfo(suc);
            quit();
        }

        public ArrayList getMails()
        {
            lock (infolock)
            {
                if (info == suc)
                    return mails;
                else
                    return null;
            }
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
