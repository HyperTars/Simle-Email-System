using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace MailClient
{
    class NetService
    {
        NetworkStream nwStream;
        TcpClient sock;
        string add;
        int port;
        bool quit;

        Object sendlock;
        string msgsend;
        Queue<string> msgrecv;

        static char[] cr_lf = { (char)13, (char)10 };
        static string crlf = new string(cr_lf);

        NetService() { }

        public NetService(string add, int port)
        {
            quit = false;
            this.add = add;
            this.port = port;
            msgsend = "";

            sock = new TcpClient();
            msgrecv = new Queue<string>();
            sendlock = new Object();
            new Thread(connect).Start();
        }

        void connect()
        {
            sock.Connect(add, port);
            nwStream = sock.GetStream();
            Thread tsend = new Thread(new ThreadStart(send));
            Thread trecv = new Thread(new ThreadStart(recv));
            tsend.Start();
            trecv.Start();

            tsend.Join();
            trecv.Join();

            sock.Close();
            //System.Windows.Forms.MessageBox.Show("Session Closed");
        }

        void send()
        {
            while (!quit)
            {
                lock (sendlock)
                {
                    if (msgsend != "")
                    {
                        lock (nwStream)
                        {

                            if (nwStream.CanWrite)
                            {
                                byte[] data = Encoding.UTF8.GetBytes(msgsend);
                                nwStream.Write(data, 0, data.Length);

                                if (msgsend == "QUIT" + crlf)
                                    quit = true;

                                msgsend = "";
                            }
                        }
                    }
                }
                Thread.Sleep(10);
            }
        }

        void recv()
        {
            while (!quit)
            {
                lock (nwStream)
                {
                    if (nwStream.DataAvailable)
                    {
                        byte[] data = new byte[1024];
                        int len = 1024;
                        MemoryStream msl = new MemoryStream();

                        while (true)
                            if (nwStream.CanRead)
                            {
                                int r = nwStream.Read(data, 0, len);
                                if (r <= 0)
                                    continue;
                                msl.Write(data, 0, r);
                                if (Encoding.Default.GetString(msl.GetBuffer()).Contains(crlf))
                                    break;
                            }

                        lock (msgrecv)
                            msgrecv.Enqueue(Encoding.UTF8.GetString(msl.GetBuffer()).TrimEnd('\0'));
                    }
                }
                Thread.Sleep(10);
            }
        }

        public bool send(string send)
        {
            lock (sendlock)
            {
                if (msgsend == "")
                    msgsend = send;
                return msgsend != "";
            }
        }

        public string getmsg()
        {
            string msg = "";
            lock (msgrecv)
            {
                while (msgrecv.Count > 0)
                    msg += msgrecv.Dequeue();
            }
            return msg;
        }
    }
}
