using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Weather
{
    public class APIs
    {
        public async Task<Model> GetApi(string temperature)
        {


            string unit = Xamarin.Essentials.Preferences.Get("Swap", "metric");



            var client = new HttpClient();

            var response = await client.GetAsync("https://api.openweathermap.org/data/2.5/weather?q=Perth&appid=b6832d30647d1d6335cc05a368d03b71&units=" + unit + "");

            var responseString = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseString);

            var obj = JsonConvert.DeserializeObject<JObject>(responseString);

            Model model = new Model();

            model.Perthtemperature = obj.Value<JObject>("main").Value<float>("temp");

            model.description = obj.Value<JArray>("weather")[0].Value<string>("description");

            return model;
        }
    }
}
