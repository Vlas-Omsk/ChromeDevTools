using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Database
{

	[SupportedBy("IOS")]
	public class ExecuteSQLCommand: ICommand<ExecuteSQLCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Database.ExecuteSQL;
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
