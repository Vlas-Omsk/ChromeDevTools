using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{

	[SupportedBy("Chrome")]
	public class QueryObjectsCommandParams: ICommandParams<QueryObjectsCommandResult>
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
