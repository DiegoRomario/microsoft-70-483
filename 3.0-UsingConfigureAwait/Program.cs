using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0_UsingConfigureAwait
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    HttpClient httpClient = new HttpClient();
        //    string content = await httpClient
        //        .GetStringAsync("http://www.microsoft.com")

        //        .ConfigureAwait(false);
        //    Output.Content = content;
        //}

        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    HttpClient httpClient = new HttpClient();
        //    string content = await httpClient
        //        .GetStringAsync("http://www.microsoft.com")

        //        .ConfigureAwait(false);
        //    using (FileStream sourceStream = new FileStream("temp.html",
        //   FileMode.Create, FileAccess.Write, FileShare.None,
        //   4096, useAsync: true))
        //    {
        //        byte[] encodedText = Encoding.Unicode.GetBytes(content);
        //        await sourceStream.WriteAsync(encodedText, 0, encodedText.Length)
        //            .ConfigureAwait(false);
        //    };
        //}
    }
}
