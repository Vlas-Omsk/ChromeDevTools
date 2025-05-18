using System;

namespace MasterDevs.ChromeDevTools.Protocol
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class EventNameAttribute : Attribute
    {
        public EventNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
