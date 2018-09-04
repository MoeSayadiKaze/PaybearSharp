using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PaybearSharp
{
    public  class ExchangeRatesItem
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, ExchangeRateItemData> Data { get; set; }
        public static ExchangeRatesItem FromJson(string json) => JsonConvert.DeserializeObject<ExchangeRatesItem>(json, Converter.Settings);

    }

    
}