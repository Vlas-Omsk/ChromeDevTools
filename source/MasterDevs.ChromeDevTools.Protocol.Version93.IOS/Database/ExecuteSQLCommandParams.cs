using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Database
{

	[SupportedBy("IOS")]
	public class ExecuteSQLCommandParams: ICommandParams<ExecuteSQLCommandResult>
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