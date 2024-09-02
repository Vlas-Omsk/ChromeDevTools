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
	public class GetPropertiesCommandResult : ICommandResult
	{
		/// <summary>
		/// Object properties.
		/// </summary>
		public PropertyDescriptor[] Result { get; set; }
		/// <summary>
		/// Internal object properties (only of the element itself).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public InternalPropertyDescriptor[] InternalProperties { get; set; }
		/// <summary>
		/// Object private properties.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PrivatePropertyDescriptor[] PrivateProperties { get; set; }
		/// <summary>
		/// Exception details.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
