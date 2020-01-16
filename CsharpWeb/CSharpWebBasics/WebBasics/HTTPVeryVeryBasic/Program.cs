using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HTTPVeryVeryBasic
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const string NewLine = "\r\n";

            TcpListener listener = new TcpListener(IPAddress.Loopback, 80);
            listener.Start();

            while (true) // Demon in Linux ... 
            {
                TcpClient client = listener.AcceptTcpClient();
                using (NetworkStream networkStream = client.GetStream())
                {
                    //Use buffer
                    byte[] requestBytes = new byte[1000000];
                    int bytesRead = networkStream.Read(requestBytes, 0, requestBytes.Length);
                    string request = Encoding.UTF8.GetString(requestBytes, 0, bytesRead);
                    string responseText = @"<form action ='/Account/Login' method = 'post' >
                                 <input type = date name = 'date'/>
                                 <input type = text name = 'username'/>
                                 <input type = password = 'password'/>
                                 <input type = submit value = 'Login'/>
                                           </form>";
                    byte[] responseBytes = Encoding.UTF8.GetBytes(responseText);

                    string response = "HTTP/1.0 307 Relocation" + NewLine +
                        "Server: BGMapsServer/1.0" + NewLine +
                        "Content - Type: text/html" + NewLine +
                        "Location: https://duckduckgo.com" + NewLine +
                        //"Content - Disposition: attachment; filename=download.html" + NewLine +
                        "Content - Lenght: " + responseText.Length + NewLine
                         + NewLine +
                         responseText;


                    networkStream.Write(responseBytes, 0, responseBytes.Length);


                    Console.WriteLine(request);
                    Console.WriteLine(new string('=', 60));
                }

            }

        }

        public static async Task HttpRequest()
        {
            // request -get
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://www.bgmaps.com/");
            string result = await message.Content.ReadAsStringAsync();
            Console.WriteLine(result);
            File.WriteAllText("index.html", result);

            //request -post

            //request - response 

        }
    }
}
