using iex.lib;
using iex.lib.DataProviders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace utl.lib.tests
{
    [TestClass]
    public class StockQuoteTests
    {
        [TestMethod]
        public void get_json_from_endpoint()
        {
            var sut = new IEXDataProvider();
            var response = sut.GetQuotesAsJson("MSFT,GOOG").Result;
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void deserialize_json_into_quotes()
        {
            var sut = new IEXDataProvider();
            var response = sut.GetQuotesAsJson("MSFT,GOOG").Result;
            foreach(var node in response)
            {
                var symbol = node.Key;
                var q = node.Value as JObject;
                var quote = q["quote"];
                var q2 = quote.ToObject<Quote>();
                Assert.AreEqual(symbol, q2.symbol);
            }
;        }

        [TestMethod]
        public void get_single_quote()
        {
            var sut = new IEXDataProvider();
            var response = sut.GetQuotes("MSFT").Result;
            Assert.AreEqual(1, response.Count());

        }

        [TestMethod]
        public void get_multiple_quotes()
        {
            var sut = new IEXDataProvider();
            var response = sut.GetQuotes("AAPL,GOOG,MSFT").Result;
            Assert.AreEqual(3, response.Count());
        }

        [TestMethod]
        public void get_chart_json()
        {
            var sut = new IEXDataProvider();
            var response = sut.GetChartJson("AAPL").Result;
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void get_chart_json_serialize_as_chartdata()
        {
            var sut = new IEXDataProvider();
            var response = sut.GetChartJson("AAPL").Result;
            var chart = response.ToObject<List<ChartData>>();
            Assert.IsNotNull(chart);
            Assert.IsTrue(chart.Count > 1);
        }

        [TestMethod]
        public void get_chart_data_daily()
        {
            var sut = new IEXDataProvider();
            var response = sut.GetChartData("AAPL", "1d").Result;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 1);
        }

        [TestMethod]
        public void valid_timeframes()
        {
            var sut = new IEXDataProvider();
            Assert.IsTrue(sut.IsValidTimeFrame(string.Empty));
            Assert.IsTrue(sut.IsValidTimeFrame(""));
            Assert.IsTrue(sut.IsValidTimeFrame(null));
            Assert.IsTrue(sut.IsValidTimeFrame("ytd"));
            Assert.IsTrue(sut.IsValidTimeFrame("5y"));
            Assert.IsTrue(sut.IsValidTimeFrame("6m"));
            Assert.IsTrue(sut.IsValidTimeFrame("3m"));
            Assert.IsTrue(sut.IsValidTimeFrame("1m"));
            Assert.IsTrue(sut.IsValidTimeFrame("1d"));
            Assert.IsTrue(sut.IsValidTimeFrame("date/20180129"));
            Assert.IsFalse(sut.IsValidTimeFrame("1s"));
        }
    }
}
