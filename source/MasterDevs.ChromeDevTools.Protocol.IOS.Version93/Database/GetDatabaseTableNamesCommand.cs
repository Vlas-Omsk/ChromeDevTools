using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Database
{

	[SupportedBy("IOS")]
	public class GetDatabaseTableNamesCommand: ICommand<GetDatabaseTableNamesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Database.GetDatabaseTableNames;
		/// <summary>
		/// DatabaseId
		/// </summary>
		public string DatabaseId { get; set; }
	}
}
