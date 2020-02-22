using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1_UsingConfigureAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            string content = await httpClient
                .GetStringAsync("http://www.microsoft.com");
            content = await httpClient
            .GetStringAsync("http://www.microsoft.com");
            content = await httpClient
            .GetStringAsync("http://www.microsoft.com");
            content = await httpClient
            .GetStringAsync("http://www.microsoft.com");
            content = await httpClient
            .GetStringAsync("http://www.microsoft.com");
            content = await httpClient
            .GetStringAsync("http://www.microsoft.com");
            content = await httpClient
            .GetStringAsync("http://www.microsoft.com");
            content = await httpClient
            .GetStringAsync("http://www.microsoft.com");
            content = await httpClient
            .GetStringAsync("http://www.microsoft.com");
            content = await httpClient
            .GetStringAsync("http://www.microsoft.com")
            .ConfigureAwait(false);

            label1.Text = content.ToString().Substring(0, 10);
        }
    }
}
