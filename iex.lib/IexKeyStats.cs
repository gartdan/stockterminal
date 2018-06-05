using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;

    public class IexKeyStats : IexBase
    {
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("marketcap")]
        public long Marketcap { get; set; }

        [JsonProperty("beta")]
        public double Beta { get; set; }

        [JsonProperty("week52high")]
        public double Week52High { get; set; }

        [JsonProperty("week52low")]
        public double Week52Low { get; set; }

        [JsonProperty("week52change")]
        public double Week52Change { get; set; }

        [JsonProperty("shortInterest")]
        public long ShortInterest { get; set; }

        [JsonProperty("shortDate")]
        public DateTime ShortDate { get; set; }

        [JsonProperty("dividendRate")]
        public double DividendRate { get; set; }

        [JsonProperty("dividendYield")]
        public double DividendYield { get; set; }

        [JsonProperty("exDividendDate")]
        public string ExDividendDate { get; set; }

        [JsonProperty("latestEPS")]
        public double LatestEps { get; set; }

        [JsonProperty("latestEPSDate")]
        public DateTime LatestEpsDate { get; set; }

        [JsonProperty("sharesOutstanding")]
        public long SharesOutstanding { get; set; }

        [JsonProperty("float")]
        public long Float { get; set; }

        [JsonProperty("returnOnEquity")]
        public double ReturnOnEquity { get; set; }

        [JsonProperty("consensusEPS")]
        public double ConsensusEps { get; set; }

        [JsonProperty("numberOfEstimates")]
        public long NumberOfEstimates { get; set; }

        [JsonProperty("EPSSurpriseDollar")]
        public object EpsSurpriseDollar { get; set; }

        [JsonProperty("EPSSurprisePercent")]
        public double EpsSurprisePercent { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("EBITDA")]
        public long Ebitda { get; set; }

        [JsonProperty("revenue")]
        public long Revenue { get; set; }

        [JsonProperty("grossProfit")]
        public long GrossProfit { get; set; }

        [JsonProperty("cash")]
        public long Cash { get; set; }

        [JsonProperty("debt")]
        public long Debt { get; set; }

        [JsonProperty("ttmEPS")]
        public double TtmEps { get; set; }

        [JsonProperty("revenuePerShare")]
        public long RevenuePerShare { get; set; }

        [JsonProperty("revenuePerEmployee")]
        public long RevenuePerEmployee { get; set; }

        [JsonProperty("peRatioHigh")]
        public double PeRatioHigh { get; set; }

        [JsonProperty("peRatioLow")]
        public long PeRatioLow { get; set; }

        [JsonProperty("returnOnAssets")]
        public double ReturnOnAssets { get; set; }

        [JsonProperty("returnOnCapital")]
        public object ReturnOnCapital { get; set; }

        [JsonProperty("profitMargin")]
        public double ProfitMargin { get; set; }

        [JsonProperty("priceToSales")]
        public double PriceToSales { get; set; }

        [JsonProperty("priceToBook")]
        public double PriceToBook { get; set; }

        [JsonProperty("day200MovingAvg")]
        public double Day200MovingAvg { get; set; }

        [JsonProperty("day50MovingAvg")]
        public double Day50MovingAvg { get; set; }

        [JsonProperty("institutionPercent")]
        public double InstitutionPercent { get; set; }

        [JsonProperty("insiderPercent")]
        public object InsiderPercent { get; set; }

        [JsonProperty("shortRatio")]
        public double ShortRatio { get; set; }

        [JsonProperty("year5ChangePercent")]
        public double Year5ChangePercent { get; set; }

        [JsonProperty("year2ChangePercent")]
        public double Year2ChangePercent { get; set; }

        [JsonProperty("year1ChangePercent")]
        public double Year1ChangePercent { get; set; }

        [JsonProperty("ytdChangePercent")]
        public double YtdChangePercent { get; set; }

        [JsonProperty("month6ChangePercent")]
        public double Month6ChangePercent { get; set; }

        [JsonProperty("month3ChangePercent")]
        public double Month3ChangePercent { get; set; }

        [JsonProperty("month1ChangePercent")]
        public double Month1ChangePercent { get; set; }

        [JsonProperty("day5ChangePercent")]
        public double Day5ChangePercent { get; set; }

        public static IexKeyStats FromJson(string json) => JsonConvert.DeserializeObject<IexKeyStats>(json, JsonSettings);

        public static string ToJson(IexKeyStats item) => JsonConvert.SerializeObject(item, JsonSettings);


    }
