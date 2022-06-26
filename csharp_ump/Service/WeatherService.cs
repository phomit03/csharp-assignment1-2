using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2108M_UMP.Module.CurentWeather;
using System.Net.Http;
using Newtonsoft.Json;

namespace T2108M_UMP.Service
{
   class WeatherService
    {
        public async Task<CurentWeather> GetForeCastWeather()
        {
            HttpClient client = new HttpClient();
            string url = "http://api.openweathermap.org/data/2.5/forecast?q=London,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
            var rs = await client.GetAsync(url);
            if (rs.IsSuccessStatusCode)
            {
                var stringContent = await rs.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<CurentWeather>(stringContent);
            }
            return null;

        }
    }
}
