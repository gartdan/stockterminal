using CommandLine;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using stx.lib.DataProviders;
using iex.lib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using iex.lib.DataProviders;
using System.Net.Http;

namespace stx.consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLine.Parser.Default.ParseArguments<Options>(args)
                        .WithParsed<Options>(opts => RunOptionsAndReturnExitCode(opts))
                        .WithNotParsed<Options>((errs) => HandleParseError(errs));
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
            foreach(var err in errs)
            {
                Console.WriteLine($"An error occurred while parsing: {err.ToString()}");
            }
        }

        private static void RunOptionsAndReturnExitCode(Options opts)
        {
            IConfiguration config = LoadConfig();
            try
            {
                Run(opts, config);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"A network error occurred. Please check your network connection. {ex.Message}");
            }

        }

        private static IConfiguration LoadConfig()
        {
            return new ConfigurationBuilder()
                   .AddJsonFile("appsettings.json", true, true)
                   .Build();
        }

        private static void Run(Options opts, IConfiguration config)
        {
            if (opts.Symbols.Count() > 0)
            {
                IEnumerable<string> symbols = ParseSymbols(opts);
                GetQuotes(symbols, config);
            }
            else if (!string.IsNullOrEmpty(opts.Chart))
            {
                GetChart(opts.Chart, opts.Timeframe);
            }
            else if(!string.IsNullOrEmpty(opts.News))
            {
                GetNews(opts.News);
            }
        }

        public static void GetChart(string symbol, string timeframe)
        {
            var provider = new IEXDataProvider();
            var chart = provider.GetChartData(symbol, timeframe).Result;
            foreach(var d in chart)
            {
                Console.WriteLine(PrettyConsoleFormatter.FormatAsLine(d));
            }
        }

        public static void GetNews(string symbol)
        {
            var provider = new IEXDataProvider();
            var news = provider.GetNews(symbol).Result;
            foreach(var item in news)
            {
                Console.WriteLine(PrettyConsoleFormatter.FormatNews(item));
            }
                        
        }

        public static void GetQuotes(IEnumerable<string> symbols, IConfiguration config)
        {
            var quoteProvider = new IEXDataProvider();
            var quotes = quoteProvider.GetQuotes(symbols.ToArray()).Result;
            PrintQuotes(quotes);
            Console.WriteLine("Done.");
#if DEBUG
            Console.ReadKey();
#endif

        }

        private static void PrintQuotes(IEnumerable<Quote> quotes)
        {
            Console.WriteLine(PrettyConsoleFormatter.FormatQuoteHeaderLine());
            foreach (var quote in quotes)
            {
                if(quote.change.GetValueOrDefault() >= 0.0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(PrettyConsoleFormatter.FormatAsLine(quote));
            }
            Console.ResetColor();
        }

        private static IEnumerable<string> ParseSymbols(Options opts)
        {
            var symbols = opts.Symbols;
            if (symbols == null)
                throw new ArgumentNullException("symbols");
            if (symbols.Count() == 1)
            {
                symbols = ParseSymbols(symbols.First());
            }
            return symbols;
        }

        private static IEnumerable<string> ParseSymbols(string symbols)
        {
            return symbols.Split(new char[] { ',', ';' }).Select(x => x.Trim());
        }
    }
}
