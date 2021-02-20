using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coin_API.Models
{
    public class CoinClientModel
    {
        public int id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public string nameid { get; set; }
        public int rank { get; set; }
        public double price_usd { get; set; }
        public double percent_change_24h { get; set; }
        public double percent_change_1h { get; set; }
        public double percent_change_7d { get; set; }
        public double price_btc { get; set; }
        public double market_cap_usd { get; set; }
        public double volume24 { get; set; }
        public double volume24a { get; set; }

    }
}