using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _3._4_ExecutingMultipleAwaits
{
    class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            await ExecuteMultipleRequests();
        }
        public static async Task ExecuteMultipleRequests()
        {
            HttpClient client = new HttpClient();
            string microsoft = await client.GetStringAsync("http://www.microsoft.com");
            string msdn = await client.GetStringAsync("http://msdn.microsoft.com");
            string blogs = await client.GetStringAsync("http://blogs.msdn.com/");
        }
    }
}
