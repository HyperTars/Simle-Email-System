using System;
using System.Collections.Generic;
using System.Text;

namespace MailClient
{
    public class MailAccount
    {
        string username;
        string password;

        string pop3add;
        int pop3port;

        string smtpadd;
        int smtpport;

        public MailAccount()
        {
        }

        public MailAccount(string username, string password, 
            string pop3add, int pop3port,
            string smtpadd, int smtpport)
        {
            this.username = username;
            this.password = password;
            this.pop3add = pop3add;
            this.pop3port = pop3port;
            this.smtpadd = smtpadd;
            this.smtpport = smtpport;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Pop3add { get => pop3add; set => pop3add = value; }
        public int Pop3port { get => pop3port; set => pop3port = value; }
        public string Smtpadd { get => smtpadd; set => smtpadd = value; }
        public int Smtpport { get => smtpport; set => smtpport = value; }
    }
}
