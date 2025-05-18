using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Runtime
{
	/// <summary>
	/// Returns displayable properties of a given object. Object group of the result is inherited from the target object. Displayable properties are own properties, internal properties, and native getters in the prototype chain (assumed to be bindings and treated like own properties for the frontend).
	/// </summary>

	[SupportedBy("IOS")]
	public class GetDisplayablePropertiesCommand: ICommand<GetDisplayablePropertiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.GetDisplayableProperties;
		/// <summary>
		/// Identifier of the object to return properties for.
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Whether preview should be generated for property values.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
	}
}
