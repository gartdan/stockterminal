using iex.lib.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace iex.lib.DataProviders
{
    public class IEXDataProvider : StockDataProvider
    {
        static readonly string ChartEndpointUrlFormat = "https://api.iextrading.com/1.0/stock/{0}/chart/{1}";
        static readonly string BatchEndpointUrlFormat = "https://api.iextrading.com/1.0/stock/market/batch?symbols={0}&types=quote";
        static readonly string[] ValidTimeframes = { "5y", "2y", "1y", "ytd", "6m", "3m", "1m", "1d", "dynamic" };
        public async Task<JObject> GetQuotesAsJson(params string[] symbols)
        {
            return await GetQuotesAsJson(symbols.ToCommaDelimited());
        }

        public async Task<JObject> GetQuotesAsJson(string symbols)
        {
            string url = string.Format(BatchEndpointUrlFormat, symbols);
            return await GetJson(url);
        }

        public async Task<IEnumerable<Quote>> GetQuotes(params string[] symbols)
        {
            var response = await this.GetQuotesAsJson(symbols.ToCommaDelimited());
            var quotes = new List<Quote>();
            foreach (var node in response)
            {
                var symbol = node.Key;
                var q = node.Value as JObject;
                var quote = q["quote"];
                var q2 = quote.ToObject<Quote>();
                quotes.Add(q2);
            }
            return quotes;
        }

        public async Task<JArray> GetChartJson(string symbol, string timeframe)
        {
            if (!IsValidTimeFrame(timeframe)) throw new ArgumentException("invalid timeframe");
            string url = string.Format(ChartEndpointUrlFormat, symbol, timeframe);
            return await GetJsonArray(url);
        }

        public async Task<JArray> GetChartJson(string symbol)
        {
            return await GetChartJson(symbol, string.Empty);
        }

        public async Task<IList<ChartData>> GetChartData(string symbol, string timeframe)
        {
            var response = await GetChartJson(symbol, timeframe);
            var chart = response.ToObject<List<ChartData>>();
            return chart;
        }

        public async Task<IList<ChartData>> GetChartData(string symbol)
        {
            return await GetChartData(symbol, string.Empty);
        }

        public bool IsValidTimeFrame(string timeframe)
        {
            return string.IsNullOrEmpty(timeframe) || ValidTimeframes.Contains(timeframe) || timeframe.StartsWith("date");
        }

    }
}
