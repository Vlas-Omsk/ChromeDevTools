using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Security
{
	/// <summary>
	/// Enable/disable whether all certificate errors should be ignored.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetIgnoreCertificateErrorsCommand: ICommand<SetIgnoreCertificateErrorsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Security.SetIgnoreCertificateErrors;
		/// <summary>
		/// If true, all certificate errors will be ignored.
		/// </summary>
		public bool Ignore { get; set; }
	}
}
