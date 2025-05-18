using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Database
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
