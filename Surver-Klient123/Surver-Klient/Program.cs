using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Surver_Klient
{
    internal class Program
    {
        public class ChatClinet
        {
            private TcpClient client;
            private StreamReader reader;
            private StreamWriter writer;
            public void Start()
            {
                client = new TcpClient("127.0.0.1", 12345);
                NetworkStream stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);
                Thread receiveThread = new Thread(Receive);
                receiveThread.Start();
                Thread sendThread = new Thread(Receive);

                sendThread.Start();
            }
            private void Receive()
            {
                while (true)
                {
                    try
                    {
                        string message = reader.ReadLine();
                        Console.WriteLine("Сървър" + message);
                    }
                    catch (Exception es)
                    {
                        Console.WriteLine("Error" + es.Message);
                        break;
                    }
                }
                //try
                //{
                //    string message = reader.ReadLine();
                //    Console.WriteLine("Сървър");
                //}
                //catch (Exception)
                //{

                //    throw;
                //}
            }
            private void Send()
            {
                while (true)
                {
                    try
                    {
                        string message = reader.ReadLine();
                        Console.WriteLine("Клиент" + message);
                        writer.Flush();
                    }
                    catch (Exception es)
                    {
                        Console.WriteLine("Error" + es.Message);
                        break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
           
        }
    }
}
