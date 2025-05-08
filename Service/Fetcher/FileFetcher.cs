using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Download_Manager.Service.Fetcher
{
    internal class FileFetcher
    {
        private HttpClient client;
        public string path { get; }

        public FileFetcher(string path)
        {
            client = new HttpClient();
            this.path = path;
            checkPath();
            Directory.CreateDirectory(path);
        }

        private bool checkPath() { return true; }

        public async Task<string> downloadToPath(ResponseFile responseFile) {
            
            if (!checkPath())
            {
                throw new Exception("Path is invalid");
            }

            var response = await client.GetAsync(responseFile.FileUrl);
            response.EnsureSuccessStatusCode();

            var newFilePath = path + "/" + responseFile.Title + "_" + Path.GetFileName(responseFile.FileUrl);

            using (var fs = new FileStream(newFilePath, FileMode.Create))
            {
                await response.Content.CopyToAsync(fs);
            }

            return newFilePath;
        }

    }
}
