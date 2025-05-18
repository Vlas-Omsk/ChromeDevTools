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
	public class GetCertificateCommandResult : ICommandResult
	{
		/// <summary>
		/// TableNames
		/// </summary>
		public string[] TableNames { get; set; }
	}
}
