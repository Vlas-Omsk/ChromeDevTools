using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
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
