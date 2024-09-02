using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Database
{

	[SupportedBy("Chrome")]
	public class GetDatabaseTableNamesCommandResult : ICommandResult
	{
		/// <summary>
		/// TableNames
		/// </summary>
		public string[] TableNames { get; set; }
	}
}
