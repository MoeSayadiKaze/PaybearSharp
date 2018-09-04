// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var exchangeRateItem = ExchangeRateItem.FromJson(jsonString);

using Newtonsoft.Json;

namespace PaybearSharp
{
    public  class ExchangeRateItem
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public ExchangeRateItemData Data { get; set; }
        public static ExchangeRateItem FromJson(string json) => JsonConvert.DeserializeObject<ExchangeRateItem>(json, Converter.Settings);

    }

    public  class ExchangeRateItemData
    {
        [JsonProperty("poloniex")]
        public double Poloniex { get; set; }

        [JsonProperty("hitbtc")]
        public double Hitbtc { get; set; }

        [JsonProperty("coinmarketcap")]
        public double Coinmarketcap { get; set; }

        [JsonProperty("bittrex")]
        public double Bittrex { get; set; }

        [JsonProperty("bitfinex")]
        public double Bitfinex { get; set; }

        [JsonProperty("mid")]
        public double Mid { get; set; }
    }

   

}
