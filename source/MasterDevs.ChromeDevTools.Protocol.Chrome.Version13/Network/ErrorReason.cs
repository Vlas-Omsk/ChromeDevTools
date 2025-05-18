using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network{
	/// <summary>
	/// Network level fetch failure reason.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ErrorReason
	{
			Failed,
			Aborted,
			TimedOut,
			AccessDenied,
			ConnectionClosed,
			ConnectionReset,
			ConnectionRefused,
			ConnectionAborted,
			ConnectionFailed,
			NameNotResolved,
			InternetDisconnected,
			AddressUnreachable,
			BlockedByClient,
			BlockedByResponse,
	}
}
