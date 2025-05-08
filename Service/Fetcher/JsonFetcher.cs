using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
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

        public async Task<List<ResponseFile>> fetch(String url)
        {
            return await client.GetFromJsonAsync<List<ResponseFile>>(url);
        }
    }
}
