using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Security
{
	/// <summary>
	/// Enable/disable overriding certificate errors. If enabled, all certificate error events need to
	/// be handled by the DevTools client and should be answered with `handleCertificateError` commands.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class SetOverrideCertificateErrorsCommandParams: ICommandParams<SetOverrideCertificateErrorsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Security.SetOverrideCertificateErrors;
		/// <summary>
		/// If true, certificate errors will be overridden.
		/// </summary>
		public bool Override { get; set; }
	}
}
