using System;
using System.Collections.Generic;
using System.Text;

namespace iex.lib
{
    public class ChartResponse
    {
        public ChartData[] ChartData { get; set; }
    }
    public class ChartData
    {
        public string date { get; set; }
        public float? open { get; set; }
        public float? high { get; set; }
        public float? low { get; set; }
        public float? close { get; set; }
        public int? volume { get; set; }
        public int? unadjustedVolume { get; set; }
        public float? change { get; set; }
        public float? changePercent { get; set; }
        public float? vwap { get; set; }
        public string label { get; set; }
        public float? changeOverTime { get; set; }
        public string minute { get; set; }
        public float? average { get; set; }
        public float? notional { get; set; }
        public int? numberOfTrades { get; set; }
        public float? marketHigh { get; set; }
        public float? marketLow { get; set; }
        public float? marketAverage { get; set; }
        public int? marketVolume { get; set; }
        public float? marketNotional { get; set; }
        public int? marketNumberOfTrades { get; set; }
        public int? marketOpen { get; set; }
        public float? marketClose { get; set; }
        public int? marketChangeOverTime { get; set; }
    }


    public class Rootobject
    {
        public string date { get; set; }
        public string minute { get; set; }
        public string label { get; set; }
        public float high { get; set; }
        public float low { get; set; }
        public float average { get; set; }
        public int volume { get; set; }
        public float notional { get; set; }
        public int numberOfTrades { get; set; }
        public float marketHigh { get; set; }
        public float marketLow { get; set; }
        public float marketAverage { get; set; }
        public int marketVolume { get; set; }
        public float marketNotional { get; set; }
        public int marketNumberOfTrades { get; set; }
        public float open { get; set; }
        public float close { get; set; }
        public int marketOpen { get; set; }
        public float marketClose { get; set; }
        public int changeOverTime { get; set; }
        public int marketChangeOverTime { get; set; }
    }


}
