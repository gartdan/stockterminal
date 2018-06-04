using stx.lib.Util;
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace stx.lib.DataProviders
{
    public class StockQuoteProvider
    {
        public string ApiKey { get; private set; }
        public static string UrlFormat = "https://www.alphavantage.co/query?function=BATCH_STOCK_QUOTES&symbols={0}&apikey={1}&datatype={2}";

        public StockQuoteProvider(string apiKey)
        {
            this.ApiKey = apiKey;
        }


        public IEnumerable<StockQuote> GetQuote(params string[] symbols)
        {
            return GetQuotesBatch(symbols).Result;
        }


        public async Task<IEnumerable<StockQuote>> GetQuotesBatch(IEnumerable<string> symbols)
        {
            string url = string.Format(UrlFormat, symbols.ToCommaDelimited(), ApiKey, "csv");
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(url);
            return ParseCSVResult(response);
            
        }

        private IEnumerable<StockQuote> ParseCSVResult(string response)
        {
            var lines = response.GetLines(true).ToArray();
            var quotes = new List<StockQuote>();
            if(lines.Length > 1)
            {
                for(int i = 1; i < lines.Length;i++)
                {
                    var line = lines[i];
                    var fields = line.Split(new char[] { ',' });
                    var quote = new StockQuote();
                    quote.Symbol = fields[0];
                    quote.Price = fields[1];
                    quote.Volume = int.Parse(fields[2]);
                    quote.Timestamp = fields[3];
                    quotes.Add(quote);
                }
            }
            return quotes;
        }
    }
}
