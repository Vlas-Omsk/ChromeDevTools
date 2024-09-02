using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Database
{

	[SupportedBy("IOS")]
	public class GetDatabaseTableNamesCommandResult : ICommandResult
	{
		/// <summary>
		/// TableNames
		/// </summary>
		public string[] TableNames { get; set; }
	}
}
