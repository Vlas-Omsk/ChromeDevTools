using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
{

	[SupportedBy("Chrome")]
	public class QueryObjectsCommand: ICommand<QueryObjectsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.QueryObjects;
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
