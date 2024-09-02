using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Returns properties of a given object. Object group of the result is inherited from the target
	/// object.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetPropertiesCommandParams: ICommandParams<GetPropertiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.GetProperties;
		/// <summary>
		/// Identifier of the object to return properties for.
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// If true, returns properties belonging only to the element itself, not to its prototype
		/// chain.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? OwnProperties { get; set; }
		/// <summary>
		/// If true, returns accessor properties (with getter/setter) only; internal properties are not
		/// returned either.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AccessorPropertiesOnly { get; set; }
		/// <summary>
		/// Whether preview should be generated for the results.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
		/// <summary>
		/// If true, returns non-indexed properties only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? NonIndexedPropertiesOnly { get; set; }
	}
}
