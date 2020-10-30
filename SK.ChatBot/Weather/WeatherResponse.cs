using System;

namespace SK.ChatBot.Weather
{
    public class WeatherResponse : iResponseObject
    {
        public String Source { get; private set; }
        public String Description { get; private set; }
        public int Temperature { get; private set; }
        public int FeelsLikeTemperature { get; private set; }
        public String PrecipitationType { get; private set; }
        public int PrecipitationAmount { get; private set; }
        public String Location {get; private set;}

        public WeatherResponse() { }

        public WeatherResponse(string source, string location, string description, int temp, int feelsLike) : this()
        {
            this.Source = source;
            this.Location = location;
            this.Description = description;
            this.Temperature = temp;
            this.FeelsLikeTemperature = feelsLike;
        }

        public override string ToString()
        {
            return $"{Source} says it is currently {Temperature} and feels like {FeelsLikeTemperature} in {Location}.\n{Source} gave the Description \"{Description}\"";
        }
    }
}
