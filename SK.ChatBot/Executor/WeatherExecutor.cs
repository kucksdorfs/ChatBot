namespace SK.ChatBot.Executor
{
    using SK.ChatBot.Weather;
    using System;
    using System.Reflection;
    //will eventually be used to determine which weather api to use.
    public static class WeatherExecutor
    {
        private static OpenWeatherMap openWeatherMapObj = new OpenWeatherMap();

        public static string ExecuteWeather(string[] arguments) 
        {
            if (arguments.Length < 1)
            {
                return null;
            }
            
            return openWeatherMapObj.GetCurrentWeather(arguments[1]);
        }

    }
}
