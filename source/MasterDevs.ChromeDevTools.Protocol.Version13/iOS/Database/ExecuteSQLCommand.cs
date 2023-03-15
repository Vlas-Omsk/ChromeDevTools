using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	[Command(ProtocolName.Database.ExecuteSQL)]
	[SupportedBy("iOS")]
	public class ExecuteSQLCommand: IProtocolCommand<ExecuteSQLCommandResponse>
	{
		/// <summary>
		/// DatabaseId
		/// </summary>
		public string DatabaseId { get; set; }
		/// <summary>
		/// Query
		/// </summary>
		public string Query { get; set; }
	}
}
