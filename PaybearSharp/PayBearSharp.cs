using System.Net;
using System.Web;

// ReSharper disable InconsistentNaming

namespace PaybearSharp
{
    public class PayBearSharp
    {
        private string _apiToken;
        private string _apiSecret;
        public PayBearSharp( string apiToken, string apiSecret)
        {
            _apiToken = apiToken;
            _apiSecret = apiSecret;
        }

        public CurrencyItem GetCurrencies()
        {
            var client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
            var ls = CurrencyItem.FromJson(
                client.DownloadString($"https://api.paybear.io/v2/currencies?token={_apiToken}"));
            return ls;
        }
        public ExchangeRateItem ExchangeRate(Currency currency, Coin coin)
        {
            var client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
            var ls = ExchangeRateItem.FromJson(
                client.DownloadString($"https://api.paybear.io/v2/{coin.ToString()}/exchange/{currency.ToString()}/rate"));
            return ls;
        }
        public PlaceOrderResponse PlaceOrder(Coin coin, string callbackurl)
        {
            var client = new WebClient();
            callbackurl= HttpUtility.UrlEncode(callbackurl);

            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
            var ls = PlaceOrderResponse.FromJson(
                client.DownloadString($"https://api.paybear.io/v2/{coin.ToString()}/payment/{callbackurl}?token={_apiSecret}"));
            return ls;
        }
        public ExchangeRatesItem ExchangeRate(Currency currency)
        {
            var client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
            var ls = ExchangeRatesItem.FromJson(
                client.DownloadString($"https://api.paybear.io/v2/exchange/{currency.ToString()}/rate"));
            return ls;
        }
    }
}


