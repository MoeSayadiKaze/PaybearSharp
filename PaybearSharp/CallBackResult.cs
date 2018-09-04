// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var callBackResult = CallBackResult.FromJson(jsonString);

using System.Numerics;
using Newtonsoft.Json;

namespace PaybearSharp
{
    public class CallBackResult
    {
        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("maxConfirmations")]
        public long MaxConfirmations { get; set; }

        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }

        [JsonProperty("block")]
        public Block Block { get; set; }

        [JsonProperty("inTransaction")]
        public InTransaction InTransaction { get; set; }

        public static CallBackResult FromJson(string json) => JsonConvert.DeserializeObject<CallBackResult>(json, Converter.Settings);
    
    }

    public  class Block
    {
        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public  class InTransaction
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("exp")]
        public long Exp { get; set; }

        [JsonProperty("amount")]
        public BigInteger Amount { get; set; }
    }

 
    
 
}
