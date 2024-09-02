using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position
	/// unavailable.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetGeolocationOverrideCommandParams: ICommandParams<SetGeolocationOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetGeolocationOverride;
		/// <summary>
		/// Mock latitude
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Latitude { get; set; }
		/// <summary>
		/// Mock longitude
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Longitude { get; set; }
		/// <summary>
		/// Mock accuracy
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Accuracy { get; set; }
	}
}
