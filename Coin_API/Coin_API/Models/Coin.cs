using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coin_API.Models
{
    public class Coin
    {
        public int ID { get; set; }

        public int Rank { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string NameID { get; set; }

        public double Price_USD { get; set; }
        public double Price_BTC { get; set; }

        public double Percent_Change_24hr { get; set; }

        public double Volume24 { get; set; }

        public string Image;
    }
}