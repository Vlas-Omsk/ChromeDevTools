using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Returns the DER-encoded certificate.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCertificateCommandParams: ICommandParams<GetCertificateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetCertificate;
		/// <summary>
		/// Origin to get certificate for.
		/// </summary>
		public string Origin { get; set; }
	}
}
