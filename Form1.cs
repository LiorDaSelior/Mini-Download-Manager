using Mini_Download_Manager.Service.Fetcher;
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
            var jf = new JsonFetcher();
            string res =  await jf.fetch("https://4qgz7zu7l5um367pzultcpbhmm0thhhg.lambda-url.us-west-2.on.aws/");
            textBox1.Text = res;
        }
    }
}
