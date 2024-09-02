using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Security
{
	/// <summary>
	/// Handles a certificate error that fired a certificateError event.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class HandleCertificateErrorCommandParams: ICommandParams<HandleCertificateErrorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Security.HandleCertificateError;
		/// <summary>
		/// The ID of the event.
		/// </summary>
		public long EventId { get; set; }
		/// <summary>
		/// The action to take on the certificate error.
		/// </summary>
		public string Action { get; set; }
	}
}
