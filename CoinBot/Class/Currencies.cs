using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bittrex.Net.Objects;
using Bittrex.Net;

namespace CoinBot.Class
{
    public class TelegramSignal
    {
        public int Id { get; set; }
        public string Currency  { get; set; }
        public decimal BuyPriceFrom { get; set; }
        public decimal BuyPriceTo { get; set; }
        //public decimal SellPriceFrom { get; set; }
        //public decimal SellPriceTo { get; set; }
        public DateTime GetTime { get; set; }

    }
}
