using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _3._3_ExecutingAnAsynchronousHTTPRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task<string> teste = ReadAsyncHttpRequest();
            Console.WriteLine(teste.Result.ToString());
            Console.Read();
        }
        public static async Task <string> ReadAsyncHttpRequest()
        {
            HttpClient client = new HttpClient();

            return await client.GetStringAsync("http://www.microsoft.com");
        }
    }
}
