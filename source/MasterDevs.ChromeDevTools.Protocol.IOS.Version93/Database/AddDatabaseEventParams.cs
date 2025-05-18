using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Database
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
