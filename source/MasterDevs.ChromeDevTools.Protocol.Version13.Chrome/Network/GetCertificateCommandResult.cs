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
	public class GetCertificateCommandResult : ICommandResult
	{
		/// <summary>
		/// TableNames
		/// </summary>
		public string[] TableNames { get; set; }
	}
}
