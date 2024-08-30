using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Handles a certificate error that fired a certificateError event.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Security.HandleCertificateError)]
	[SupportedBy("Chrome")]
	public class HandleCertificateErrorCommand: ICommandParams<HandleCertificateErrorCommandResponse>
	{
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
