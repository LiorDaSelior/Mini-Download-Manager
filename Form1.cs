using Microsoft.VisualBasic.Logging;
using Mini_Download_Manager.Service;
using Mini_Download_Manager.Service.Fetcher;
using Mini_Download_Manager.Service.FileLogic;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Tar;
using System.Runtime.InteropServices.JavaScript;

namespace Mini_Download_Manager
{
    public partial class DownloaderForm : Form
    {
        private JsonFetcher jsonFetcher;
        private FileLogic logic;
        private FileFetcher fileFetcher;
        private string fileFetcherPath;
        private string trgFilePath;

        private ResponseFile trgFile = null;

        public DownloaderForm()
        {
            InitializeComponent();
            jsonFetcher = new JsonFetcher();
            logic = new FileLogic();
            fileFetcherPath = Application.StartupPath + "/Temp";
            fileFetcher = new FileFetcher(fileFetcherPath);
        }


        private async void Form1_Load_1(object sender, EventArgs e)
        {
            DownloadButton.Enabled = false;
            FileNameLabel.Text = "Please wait...";

            var res = await jsonFetcher.fetch("https://4qgz7zu7l5um367pzultcpbhmm0thhhg.lambda-url.us-west-2.on.aws/");

            var best = this.logic.getValidHighestScoreFile(res);

            trgFile = best;

            FileIconBox.Load(trgFile.ImageUrl);
            FileNameLabel.Text = trgFile.Title;
            FileIconBox.Visible = true;

            DownloadButton.Enabled = true;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            DownloadButton.Enabled = false;

            if (trgFile == null) {
                return; // TODO: error pop up
            }

            string trgFilePath = await fileFetcher.downloadToPath(trgFile);

            Process.Start("explorer.exe", Path.GetFullPath(fileFetcherPath));

            Process.Start(new ProcessStartInfo
            {
                FileName = trgFilePath,
                UseShellExecute = true
            });

            DownloadButton.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}