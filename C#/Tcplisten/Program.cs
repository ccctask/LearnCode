using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Tcplisten
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 创建  tcp 监听
            TcpListener listener =new TcpListener(IPAddress.Parse("192.168.20.11"),8080);

            //开始监听
            listener.Start();

            //开始监听
            TcpClient client = listener.AcceptTcpClient();

            // 获取 监听到的 网络流
            NetworkStream stream = client.GetStream();

            // 定义一个存储  网络流的数组
            byte[] data = new byte[1024];

            //读取数据放到 data 数组， 从第0个 最多放1024 ，length：如果不满 1024  就读到length个字节 
           int length=stream.Read(data, 0, 1024);

            string message = Encoding.UTF8.GetString(data, 0,length);

            Console.WriteLine(message);

            //释放资源

            stream.Close();
            client.Close(); 
            listener.Stop();
        }
    }
}
