using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Database
{
	[EventName(ProtocolName.Database.AddDatabase)]
	[SupportedBy("IOS")]
	public class AddDatabaseEventParams : IEventParams
	{
		/// <summary>
		/// Database
		/// </summary>
		public Database Database { get; set; }
	}
}
