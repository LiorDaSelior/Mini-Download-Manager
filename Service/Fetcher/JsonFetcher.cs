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
            List<ResponseFile>? response = null;
            try
            {
                response = await client.GetFromJsonAsync<List<ResponseFile>>(url);
            }
            catch (HttpRequestException e)
            {
                throw new ServiceException("Issue Retrieveing File - " + e.Message);
            }
            if (response == null)
            {
                throw new ServiceException("Issue Retrieveing File");
            }
            return response;
        }
    }
}
