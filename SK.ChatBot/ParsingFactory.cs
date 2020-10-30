namespace SK.ChatBot
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public static class ParsingFactory
    {
        static System.Reflection.Assembly currentAssembly;

        static ParsingFactory()
        {
            List<Type> validTypes = new List<Type>();
            currentAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            var names = currentAssembly.GetManifestResourceNames();
            var types = currentAssembly.GetTypes();

            foreach (var type in types)
            {
                //if (type.Namespace.StartsWith("SK.Chatbot.Executor"))
                {
                    Console.WriteLine(type.FullName);
                }
            }
        }
        public static iResponseObject Parse(String message)
        {
            if (!message.StartsWith("!"))
            {
                return null;
            }
            string[] splitMessage = message.Split(" ");

            switch(splitMessage[0].ToUpper())
            {
                case "!WEATHER":
                    return Executor.WeatherExecutor.ExecuteWeather(splitMessage);
            }



            return null;
        }

    }
}
