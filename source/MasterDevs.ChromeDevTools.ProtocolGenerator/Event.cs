using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    public class Event : ProtocolItem
    {
        public Event()
        {
            Parameters = new Collection<Property>();
            Handlers = new Collection<string>();
        }

        public Collection<Property> Parameters
        {
            get;
            set;
        }

        public Collection<string> Handlers
        {
            get;
            set;
        }

        public bool Deprecated
        {
            get;
            set;
        }

        [JsonProperty("experimental")]
        public bool IsExperimental { get; set; }
    }
}
