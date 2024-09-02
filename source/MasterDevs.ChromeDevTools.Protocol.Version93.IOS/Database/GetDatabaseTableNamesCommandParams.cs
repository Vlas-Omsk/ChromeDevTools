using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Database
{

	[SupportedBy("IOS")]
	public class GetDatabaseTableNamesCommandParams: ICommandParams<GetDatabaseTableNamesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Database.GetDatabaseTableNames;
		/// <summary>
		/// DatabaseId
		/// </summary>
		public string DatabaseId { get; set; }
	}
}
