using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	[Command(ProtocolName.Database.GetDatabaseTableNames)]
	[SupportedBy("iOS")]
	public class GetDatabaseTableNamesCommand: IProtocolCommand<GetDatabaseTableNamesCommandResponse>
	{
		/// <summary>
		/// Gets or sets DatabaseId
		/// </summary>
		public string DatabaseId { get; set; }
	}
}
