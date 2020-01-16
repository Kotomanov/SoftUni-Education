using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace HTTPVeryVeryBasic
{
    class Program
    {
        static async Task Main(string[] args)
        {// request -get
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
