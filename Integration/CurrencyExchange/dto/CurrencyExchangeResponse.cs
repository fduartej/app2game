using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NuGet.Packaging.Signing;

namespace app2game.Integration.CurrencyExchange.dto
{
    public class CurrencyExchangeResponse
    {
        public bool success { get; set; }
        public string date { get; set; }
        public decimal result { get; set; }
        public Info info { get; set; }
    }

    public class Info
    {
        public Timestamp timestamp { get; set; }
        public string rate { get; set; }

    }
}