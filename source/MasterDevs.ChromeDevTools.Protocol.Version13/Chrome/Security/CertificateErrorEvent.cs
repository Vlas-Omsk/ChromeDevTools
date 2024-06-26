using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// There is a certificate error. If overriding certificate errors is enabled, then it should be
	/// handled with the `handleCertificateError` command. Note: this event does not fire if the
	/// certificate error has been allowed internally. Only one client per target should override
	/// certificate errors at the same time.
	/// </summary>
	[Event(ProtocolName.Security.CertificateError)]
	[SupportedBy("Chrome")]
	public class CertificateErrorEvent
	{
		/// <summary>
		/// The ID of the event.
		/// </summary>
		public long EventId { get; set; }
		/// <summary>
		/// The type of the error.
		/// </summary>
		public string ErrorType { get; set; }
		/// <summary>
		/// The url that was requested.
		/// </summary>
		public string RequestURL { get; set; }
	}
}
