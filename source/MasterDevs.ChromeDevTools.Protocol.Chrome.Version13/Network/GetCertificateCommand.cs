using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Returns the DER-encoded certificate.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCertificateCommand: ICommand<GetCertificateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetCertificate;
		/// <summary>
		/// Origin to get certificate for.
		/// </summary>
		public string Origin { get; set; }
	}
}
