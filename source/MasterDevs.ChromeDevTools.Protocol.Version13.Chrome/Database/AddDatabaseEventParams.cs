using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Database
{
	[EventName(ProtocolName.Database.AddDatabase)]
	[SupportedBy("Chrome")]
	public class AddDatabaseEventParams : IEventParams
	{
		/// <summary>
		/// Database
		/// </summary>
		public Database Database { get; set; }
	}
}
