using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Database
{

	[SupportedBy("Chrome")]
	public class ExecuteSQLCommandResult : ICommandResult
	{
		/// <summary>
		/// ColumnNames
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] ColumnNames { get; set; }
		/// <summary>
		/// Values
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object[] Values { get; set; }
		/// <summary>
		/// SqlError
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Error SqlError { get; set; }
	}
}
