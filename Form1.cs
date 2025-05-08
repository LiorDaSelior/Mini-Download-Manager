using Mini_Download_Manager.Service.Fetcher;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;

namespace Mini_Download_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            var jf = new JsonFetcher();
            var res =  await jf.fetch("https://4qgz7zu7l5um367pzultcpbhmm0thhhg.lambda-url.us-west-2.on.aws/");
            foreach (var item in res)
            {
                textBox1.Text += item.ToString();
            }
            button1.Enabled = true;
        }
    }
}