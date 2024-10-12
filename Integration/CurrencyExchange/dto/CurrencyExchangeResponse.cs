using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using NuGet.Packaging.Signing;

namespace app2game.Integration.CurrencyExchange.dto
{
    public class CurrencyExchangeResponse
    {
        public bool success { get; set; }
        public string date { get; set; }
        public decimal result { get; set; }
        public Info info { get; set; }

        public CurrencyExchangeResponse(){
            info = new Info();
        }
    }

    public class Info
    {
        public decimal timestamp { get; set; }
        public decimal rate { get; set; }

    }
}