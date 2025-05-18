using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page{
	/// <summary>
	/// Status for an Origin Trial.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OriginTrialStatus
	{
			Enabled,
			ValidTokenNotProvided,
			OSNotSupported,
			TrialNotAllowed,
	}
}
