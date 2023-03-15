using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	[Command(ProtocolName.Runtime.QueryObjects)]
	[SupportedBy("Chrome")]
	public class QueryObjectsCommand: IProtocolCommand<QueryObjectsCommandResponse>
	{
		/// <summary>
		/// Identifier of the prototype to return objects for.
		/// </summary>
		public string PrototypeObjectId { get; set; }
		/// <summary>
		/// Symbolic group name that can be used to release the results.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
	}
}
