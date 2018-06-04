using System;
using System.Collections.Generic;
using System.Text;

namespace stx.lib
{
    public class StockQuote
    {
        public string Symbol { get; set; }
        public string Price { get; set; }
        public string Timestamp { get; set; }
        public int Volume { get; set; }
    }
}
