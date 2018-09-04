// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//
//    var placeOrderResponse = PlaceOrderResponse.FromJson(jsonString);

using Newtonsoft.Json;

namespace PaybearSharp
{
    public class PlaceOrderResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public PlaceOrderResponseData Data { get; set; }
        public static PlaceOrderResponse FromJson(string json) => JsonConvert.DeserializeObject<PlaceOrderResponse>(json, Converter.Settings);

    }

    public  class PlaceOrderResponseData
    {
        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

 

  
}
