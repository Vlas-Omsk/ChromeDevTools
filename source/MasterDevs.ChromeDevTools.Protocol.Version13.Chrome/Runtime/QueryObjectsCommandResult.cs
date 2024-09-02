using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{

	[SupportedBy("Chrome")]
	public class QueryObjectsCommandResult : ICommandResult
	{
		/// <summary>
		/// Array with objects.
		/// </summary>
		public RemoteObject Objects { get; set; }
	}
}
