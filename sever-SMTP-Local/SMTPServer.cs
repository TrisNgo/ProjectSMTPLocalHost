using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;


namespace SMTPServer
{
    //Chương trình gốc
    public class SMTPServer
    {
        public static void Main()
        {
            Console.WriteLine("IP: 127.0.0.1");
            Console.WriteLine("Port: 1024");
            Console.WriteLine("Start listening...");
            Console.WriteLine();
            new System.Threading.Thread(new ThreadStart(Listener.Start)).Start();
        }
    }
}
