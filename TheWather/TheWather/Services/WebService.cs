using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TheWather.Models;

namespace TheWather.Services
{
    public class WebService
    { 
        private static HttpClient client;

        /// <summary>
        /// The HttpClient to handle all our requests
        /// </summary>
        public static HttpClient Client
        {
            get
            {
                if (client == null)
                    client = new HttpClient() { Timeout = TimeSpan.FromSeconds(10) };
                return client;
            }
        }

        /// <summary>
        /// call the API and get the data
        /// </summary>
        /// <param name="city">city name</param>
        /// <returns>WeatherResponseRoot, null if something is not correct</returns>
        public static async Task <WeatherResponseRoot> GetWeatherAsync(string city)
        {
            try
            {
                var resp = await Client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&APPID=75806ea8abd0d28aca0ce0c434fc04b7");
                if (!resp.IsSuccessStatusCode)
                {
                    return null;
                }
                var str = await resp.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<WeatherResponseRoot>(str);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }


    }
}
