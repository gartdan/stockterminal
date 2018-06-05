using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace iex.lib.DataProviders
{
    public class StockDataProvider
    {
        public async Task<string> GetString(string url)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(url);
            return response;
        }

        public async Task<JObject> GetJson(string url)
        {
            var json = await GetString(url);
            JObject jobject = JObject.Parse(json);
            return jobject;
        }


        public async Task<JArray> GetJsonArray(string url)
        {
            var json = await GetString(url);
            var array = JArray.Parse(json);
            return array;
        }
        
    }
}
