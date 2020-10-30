namespace SK.ChatBot.Weather
{
    using System;
    using SK.ChatBot.Attributes;

    [BotNamespace(TriggerWord = "Weather")]
    public abstract class iWeather
    {
        public abstract string GetLocation(string location);

        public abstract iResponseObject GetCurrentWeather(string locationId);
    }
}
