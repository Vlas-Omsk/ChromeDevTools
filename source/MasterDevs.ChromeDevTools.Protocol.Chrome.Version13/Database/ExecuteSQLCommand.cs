using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Database
{

	[SupportedBy("Chrome")]
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
