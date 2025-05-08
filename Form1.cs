using Microsoft.VisualBasic.Logging;
using Mini_Download_Manager.Service.Fetcher;
using Mini_Download_Manager.Service.FileLogic;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;

namespace Mini_Download_Manager
{
    public partial class Form1 : Form
    {
        private JsonFetcher fetcher;
        private FileLogic logic;

        public Form1()
        {
            InitializeComponent();
            fetcher = new JsonFetcher();
            logic = new FileLogic();
        }


        private async void Form1_Load_1(object sender, EventArgs e)
        {
            DownloadButton.Enabled = false;
            FileNameLabel.Text = "Please wait...";

            var res = await fetcher.fetch("https://4qgz7zu7l5um367pzultcpbhmm0thhhg.lambda-url.us-west-2.on.aws/");

            var best = this.logic.getValidHighestScoreFile(res);

            FileIconBox.Load(best.ImageUrl);
            FileNameLabel.Text = best.Title;
            FileIconBox.Visible = true;

            DownloadButton.Enabled = true;
        }
        private async void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}