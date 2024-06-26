using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	[Event(ProtocolName.Database.AddDatabase)]
	[SupportedBy("iOS")]
	public class AddDatabaseEvent
	{
		/// <summary>
		/// Database
		/// </summary>
		public Database Database { get; set; }
	}
}
