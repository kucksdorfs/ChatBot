namespace SK.ChatBot.Weather
{
    using System;
    using System.IO;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System.Net;

    public class OpenWeatherMap : iWeather
    {
        private string apiKey;

        public OpenWeatherMap()
        {
            apiKey = Environment.GetEnvironmentVariable("openweathermapkey");

            if (String.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentNullException("openweathermapkey", "The Environment Varible openweathermapkey does not exist.");
            }
        }
        private JArray PreferredMap = null;

        private const string resourceFile = "SK.ChatBot.Weather.OpenWeatherMap.city.list.min.json";
        private static readonly string[] preferredStates = { "WI", "IA", "MN" };
        private static readonly string[] preferredCountries = { "US" };

        public override string GetLocation(string location)
        {


            return null;
        }

        public override string GetCurrentWeather(string args)
        {
            WebRequest request = WebRequest.Create($"https://api.openweathermap.org/data/2.5/weather?zip={args}&appid={apiKey}&units=imperial");
            var response = request.GetResponse();
            var stream  = new StreamReader(response.GetResponseStream());
            var jsonResponse = stream.ReadToEnd();
            var jobject = JObject.Parse(jsonResponse);
            
            return jobject.ToString();;
        }
    }
}
