using CommandLine;
using System;
using System.Collections.Generic;
using System.Text;

namespace stx.consoleapp
{
    class Options {
        [Option('s', "symbol", Required = false, HelpText = "Stock symbols to lookup.")]
        public IEnumerable<string> Symbols { get; set; }

        [Option('a', "alert")]
        public string Alert { get; set; }

        [Option('c', "chart", HelpText ="Stock symbol to lookup a chart")]
        public string Chart { get; set; }

        [Option('t', "timeframe", HelpText ="Timeframe for which to return chart data")]
        public string Timeframe { get; set; }
        


    }
}
