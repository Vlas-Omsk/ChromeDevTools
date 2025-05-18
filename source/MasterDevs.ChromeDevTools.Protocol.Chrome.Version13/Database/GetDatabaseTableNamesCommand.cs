using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Database
{

	[SupportedBy("Chrome")]
	public class GetDatabaseTableNamesCommand: ICommand<GetDatabaseTableNamesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Database.GetDatabaseTableNames;
		/// <summary>
		/// DatabaseId
		/// </summary>
		public string DatabaseId { get; set; }
	}
}
