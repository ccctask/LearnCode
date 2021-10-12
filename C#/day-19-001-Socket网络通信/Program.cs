using System;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net;

namespace day19001Socket网络通信
{

    class MainClass
    {
        
        public static void Main(string[] args)
        {

            //局域网模式 , 流数据 ， TCP协议
            Socket tcpServer = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            //绑定ip 和端口号
            IPAddress iPAddress = new IPAddress(new byte[] { 10,0,2,63 });
            EndPoint point = new IPEndPoint(iPAddress, 7788);//端口

            tcpServer.Bind(point);
            //监听客户端 连接  和连接数
            tcpServer.Listen(100);





            Socket ClientScoket= tcpServer.Accept();// 暂停线程 直到 有客户端连接进来。然后进行下面的代码

            //发送数据
            string message = Console.ReadLine();
            byte[] ServerByte= Encoding.UTF8.GetBytes(message);

            ClientScoket.Send(ServerByte);

            // 接收数据

            byte[] reciveClient = new byte[1024];
            int length = tcpServer.Receive(reciveClient); //把接收的数据 赋值给reciveClien  byte数组
            string revice = Encoding.UTF8.GetString(reciveClient, 0, length);

            Console.WriteLine(revice);

            Console.ReadKey();
        }
        
    }
}
