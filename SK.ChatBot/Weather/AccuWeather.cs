namespace SK.ChatBot.Weather
{
    using System;

    public class AccuWeather : iWeather
    {
        public override string GetLocation(string location)
        {
            throw new NotImplementedException();
        }

        public override iResponseObject GetCurrentWeather(string locationId)
        {
            throw new NotImplementedException();
        }
    }
}