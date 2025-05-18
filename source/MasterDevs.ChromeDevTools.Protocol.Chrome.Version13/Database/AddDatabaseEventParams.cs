using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Database
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
