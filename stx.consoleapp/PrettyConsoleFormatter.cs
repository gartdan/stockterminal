using iex.lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace stx.consoleapp
{
    public static class PrettyConsoleFormatter
    {
        public static string FormatAsLine(ChartData d)
        {
            return $"{d.label,-12} | Open: {d.open,8} | High: {d.high,8} | Low: {d.low,8} | Close: {d.close,8} | Change: {d.change,10} | Change %: {d.changePercent,10} | Volume: {d.volume,10} | VWap: {d.vwap,8}";
        }

        public static string FormatQuoteHeaderLine()
        {
            return $"{"Ticker",-6} | {"Last",8} | {"Change",8} | {"Change%",8} | {"Open",8} | {"High",8} | {"Low",8} | {"PrevClose",10} | {"Volume",10} | {"AvgVolume",10} | {"52w High", 8} | {"52w Low", 8} | {"YTD Change",10} | {"P/E",6}";

        }

        public static string FormatAsLine(Quote quote)
        {
            return $"{quote.symbol,-6} | {quote.latestPrice,8} | {quote.change,8} | {(quote.changePercent.Value * 100).ToString("0.000"),8} | {quote.open,8} | {quote.high,8} | {quote.low,8} | {quote.previousClose,10} | {quote.latestVolume,10} | {quote.avgTotalVolume,10} | {quote.week52High.Value.ToString("0.00"),8} | {quote.week52Low.Value.ToString("0.00"),8} | {(quote.ytdChange.Value * 100).ToString("0.00"),10} | {quote.peRatio,6}";
        }

        public static string FormatNews(IexNews item)
        {
            return $"{item.Datetime, -14} | {item.Headline, 40} | {item.Url}";
        }
    }
}
