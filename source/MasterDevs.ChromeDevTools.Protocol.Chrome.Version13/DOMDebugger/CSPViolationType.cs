using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOMDebugger{
	/// <summary>
	/// CSP Violation type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CSPViolationType
	{
			[EnumMember(Value = "trustedtype-sink-violation")]
			Trustedtype_sink_violation,
			[EnumMember(Value = "trustedtype-policy-violation")]
			Trustedtype_policy_violation,
	}
}
