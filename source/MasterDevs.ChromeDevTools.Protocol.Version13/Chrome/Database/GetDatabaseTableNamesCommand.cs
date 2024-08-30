using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Database
{
	[Command(ProtocolName.Database.GetDatabaseTableNames)]
	[SupportedBy("Chrome")]
	public class GetDatabaseTableNamesCommand: ICommandParams<GetDatabaseTableNamesCommandResponse>
	{
		/// <summary>
		/// DatabaseId
		/// </summary>
		public string DatabaseId { get; set; }
	}
}
