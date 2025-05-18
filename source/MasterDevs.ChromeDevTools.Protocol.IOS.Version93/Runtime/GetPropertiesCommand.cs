using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Runtime
{
	/// <summary>
	/// Returns properties of a given object. Object group of the result is inherited from the target object.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetPropertiesCommand: ICommand<GetPropertiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.GetProperties;
		/// <summary>
		/// Identifier of the object to return properties for.
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// If true, returns properties belonging only to the object itself, not to its prototype chain.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? OwnProperties { get; set; }
		/// <summary>
		/// Whether preview should be generated for property values.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
	}
}
