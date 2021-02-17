using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace Echo
{
    class EchoServer
    {
        [Obsolete]
        static void Main(string[] args)
        {

            Console.CancelKeyPress += delegate
            {
                System.Environment.Exit(0);
            };

            TcpListener ServerSocket = new TcpListener(5000);
            ServerSocket.Start();

            Console.WriteLine("Server started.");
            while (true)
            {
                TcpClient clientSocket = ServerSocket.AcceptTcpClient();
                handleClient client = new handleClient();
                client.startClient(clientSocket);
            }


        }
    }

    public class handleClient
    {
        static string HTTP_ROOT = @"D:\Users\io\Desktop\SI4\S8\SoC_WS\TD\TD1\eiin839\TD1\Echo\www\pub";
        TcpClient clientSocket;
        public void startClient(TcpClient inClientSocket)
        {
            this.clientSocket = inClientSocket;
            Thread ctThread = new Thread(Echo);
            ctThread.Start();
        }



        private void Echo()
        {
            NetworkStream stream = clientSocket.GetStream();
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);

            string header = "HTTP/1.0 200 OK";

            string fichierHTML = File.ReadAllText(HTTP_ROOT + "\\index.html");

            while (true)
            {
                string str = reader.ReadString();
                if (str.Equals("GET /index.html"))
                {
                    Console.Write("Requête prise en compte");
                    writer.Write(header + "\n" + fichierHTML);
                }
                else
                {
                    Console.WriteLine(str);
                    writer.Write(str);
                }
            }
        }



    }

}