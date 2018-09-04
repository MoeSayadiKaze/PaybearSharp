// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var currencyItem = CurrencyItem.FromJson(jsonString);

using Newtonsoft.Json;

namespace PaybearSharp
{
    public class CurrencyItem
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public CurrencyItemData Data { get; set; }

        public static CurrencyItem FromJson(string json) => JsonConvert.DeserializeObject<CurrencyItem>(json, Converter.Settings);
    }

    public  class CurrencyItemData
    {
        [JsonProperty("eth")]
        public Coin Eth { get; set; }

        [JsonProperty("btc")]
        public Coin Btc { get; set; }

        [JsonProperty("ltc")]
        public Coin Ltc { get; set; }

        [JsonProperty("dash")]
        public Coin Dash { get; set; }

        [JsonProperty("BCH")]
        public Coin Bch { get; set; }

        [JsonProperty("ETC")]
        public Coin Etc { get; set; }

        [JsonProperty("BTG")]
        public Coin Btg { get; set; }
    }

    public  class Coin
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("minimum")]
        public double Minimum { get; set; }

        [JsonProperty("maximum")]
        public double Maximum { get; set; }

        [JsonProperty("decimals")]
        public long Decimals { get; set; }

        [JsonProperty("maxConfirmations")]
        public long MaxConfirmations { get; set; }

        [JsonProperty("metamask")]
        public bool Metamask { get; set; }

        [JsonProperty("blockExplorer")]
        public string BlockExplorer { get; set; }

        [JsonProperty("walletLink")]
        public string WalletLink { get; set; }
    }
}
