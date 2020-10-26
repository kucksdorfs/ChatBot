namespace SK.ChatBot.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class BotNamespaceAttribute : Attribute
    {

        public String EnvironmentAPIKey { get; set; }
        public String TriggerWord { get; set; }
        public int Priority { get; set; }
        public BotNamespaceAttribute() : base()
        {
        }
    }

}