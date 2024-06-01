using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YuControl
{
    internal class Program
    {
        static string SocketServer(string ServerIP, string Text)
        {
           int  Port = 20987;
            try
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(IPAddress.Parse(ServerIP), Port);
                byte[] bytes = Encoding.UTF8.GetBytes(Text);
                socket.Send(bytes);
                byte[] array = new byte[1024];
                int count = socket.Receive(array);
                string text = Encoding.UTF8.GetString(array, 0, count);
                return text;
            }
            catch (Exception)
            {

                return "null";
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("=========欢迎使用YuControl V1.0=======");
            Console.WriteLine("→请输入服务端IP(端口默认10087):"); 
            string ip =  Console.ReadLine();
            string res = SocketServer(ip,"cx");
            if (res == "null")
            {
                Console.WriteLine("Connect Failed! 阿欧 服务器不在线或者是输错了Ip?请自行检查服务端");
                Console.WriteLine("按任意键退出~~~~~~~~~");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(res);
                Console.WriteLine("→By:YU_Office【√】");
                Console.WriteLine("请输入你想要的操作");
                Console.WriteLine("List:\n[1.查询服务器信息]\n[2.管理员系统]\n[3.服务器管理系统]\n[4.称号系统]\n其他功能敬请期待....");
                Console.WriteLine("请在键盘上方按下对应数字");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        break;
                    case ConsoleKey.D7:
                        break;
                    case ConsoleKey.D8:
                        break;
                    case ConsoleKey.D9:
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
