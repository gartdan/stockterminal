﻿using iex.lib;
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

        public static string FormatStats(IexKeyStats item)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Company Name: {item.CompanyName}");
            sb.AppendLine($"Market Cap: {item.Marketcap}");
            sb.AppendLine($"Beta: {item.Beta}");
            sb.AppendLine($"52 Week High: {item.Week52High}");
            sb.AppendLine($"52 Week low: {item.Week52Low}");
            sb.AppendLine($"52 Week Change: {item.Week52Change}");
            sb.AppendLine($"Short Interest: {item.ShortInterest}");
            sb.AppendLine($"Short Date: {item.ShortDate}");
            sb.AppendLine($"Short Ratio: {item.ShortRatio}");
            sb.AppendLine($"Dividend Rate: {item.DividendRate}");
            sb.AppendLine($"Dividend Yield: {item.DividendYield}");
            sb.AppendLine($"Ex Dividend Date: {item.ExDividendDate}");
            sb.AppendLine($"Latest EPS: {item.LatestEps}");
            sb.AppendLine($"Latest EPS Date: {item.LatestEpsDate}");
            sb.AppendLine($"Shares Outstanding: {item.SharesOutstanding}");
            sb.AppendLine($"Float: {item.Float}");
            sb.AppendLine($"Return on Equity: {item.ReturnOnEquity}");
            sb.AppendLine($"Return on Capital: {item.ReturnOnCapital}");
            sb.AppendLine($"Return on Assets: {item.ReturnOnAssets}");
            sb.AppendLine($"Consensus EPS: {item.ConsensusEps}");
            sb.AppendLine($"Number of Estimates: {item.NumberOfEstimates}");
            sb.AppendLine($"EBITDA: {item.Ebitda}");
            sb.AppendLine($"Revenue: {item.Revenue}");
            sb.AppendLine($"Gross Profit: {item.GrossProfit}");
            sb.AppendLine($"Cash: {item.Cash}");
            sb.AppendLine($"Debt: {item.Debt}");
            sb.AppendLine($"TTMEPS: {item.TtmEps}");
            sb.AppendLine($"Revenue Per Share: {item.RevenuePerShare}");
            sb.AppendLine($"Revenue Per Employee: {item.RevenuePerEmployee}");
            sb.AppendLine($"P/E High: {item.PeRatioHigh}");
            sb.AppendLine($"P/E Low: {item.PeRatioLow}");


            return sb.ToString();
        }
    }
}
