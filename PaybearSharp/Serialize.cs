using Newtonsoft.Json;

namespace PaybearSharp
{
    public static class Serialize
    {
        public static string ToJson(this CurrencyItem self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this ExchangeRateItem self) => JsonConvert.SerializeObject((object)self, (JsonSerializerSettings)Converter.Settings);
        public static string ToJson(this PlaceOrderResponse self) => JsonConvert.SerializeObject((object)self, (JsonSerializerSettings)Converter.Settings);
        public static string ToJson(this CallBackResult self) => JsonConvert.SerializeObject((object)self, (JsonSerializerSettings)Converter.Settings);
        public static string ToJson(this ExchangeRatesItem self) => JsonConvert.SerializeObject((object)self, (JsonSerializerSettings)Converter.Settings);

    }
}