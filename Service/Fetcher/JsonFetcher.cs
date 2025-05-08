using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Download_Manager.Service.Fetcher
{
    internal class JsonFetcher
    {
        private HttpClient client;

        public JsonFetcher()
        {
            client = new HttpClient();
        }

        public async Task<String> fetch(String url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
