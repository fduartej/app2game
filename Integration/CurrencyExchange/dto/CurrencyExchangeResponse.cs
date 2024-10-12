using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace app2game.Integration.CurrencyExchange.dto
{
    public class CurrencyExchangeResponse
    {
        public bool success { get; set; }
         
        [JsonPropertyName("date")]
        public string? dateExchange { get; set; }
        public decimal result { get; set; }
        public Info? info { get; set; }

    }

    public class Info
    {
        [JsonPropertyName("timestamp")]
        public decimal timestampRate { get; set; }
        public decimal rate { get; set; }

    }
}