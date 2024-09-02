using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{

	[SupportedBy("Chrome")]
	public class SetDocumentCookieDisabledCommandParams: ICommandParams<SetDocumentCookieDisabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetDocumentCookieDisabled;
		/// <summary>
		/// Whether document.coookie API should be disabled.
		/// </summary>
		public bool Disabled { get; set; }
	}
}
