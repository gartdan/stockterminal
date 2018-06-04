using System;
using System.Collections.Generic;
using System.Text;

namespace iex.lib
{

    public class Quote
    {
        public string symbol { get; set; }
        public string companyName { get; set; }
        public string primaryExchange { get; set; }
        public string sector { get; set; }
        public string calculationPrice { get; set; }
        public float? open { get; set; }
        public long? openTime { get; set; }
        public float? close { get; set; }
        public long? closeTime { get; set; }
        public float? high { get; set; }
        public float? low { get; set; }
        public float? latestPrice { get; set; }
        public string latestSource { get; set; }
        public string latestTime { get; set; }
        public long? latestUpdate { get; set; }
        public int? latestVolume { get; set; }
        public float? iexRealtimePrice { get; set; }
        public int? iexRealtimeSize { get; set; }
        public long? iexLastUpdated { get; set; }
        public float? delayedPrice { get; set; }
        public long? delayedPriceTime { get; set; }
        public float? previousClose { get; set; }
        public float? change { get; set; }
        public float? changePercent { get; set; }
        public float? iexMarketPercent { get; set; }
        public int? iexVolume { get; set; }
        public int? avgTotalVolume { get; set; }
        public float? iexBidPrice { get; set; }
        public int? iexBidSize { get; set; }
        public float? iexAskPrice { get; set; }
        public int? iexAskSize { get; set; }
        public long? marketCap { get; set; }
        public float? peRatio { get; set; }
        public float? week52High { get; set; }
        public float? week52Low { get; set; }
        public float? ytdChange { get; set; }
    }



    public class BatchResponse
    {
        public IList<Quote> Quotes { get; set; }
    }

    

    

    

    


}
