using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TheWeather
{
    public class TakeWeatherInformation
    {
        private static HttpClient client = new HttpClient();
        private string baseAdressUrl = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22London%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

        public TakeWeatherInformation()
        {
            client.BaseAddress = new Uri(baseAdressUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private string TakeCityUrl(string city)
        {
            string theResult = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22"
                + city
                + "%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
            return theResult;
        }

        public async Task<dynamic> GetAsync(string city)
        {
            dynamic weather = null;
            HttpResponseMessage response = await client.GetAsync(TakeCityUrl(city));
            if (response.IsSuccessStatusCode)
            {
                weather = response.Content.ReadAsStringAsync();
            }
            return weather;
        }
    }
}
