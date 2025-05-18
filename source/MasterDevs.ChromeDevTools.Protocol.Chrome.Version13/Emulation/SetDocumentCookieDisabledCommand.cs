using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{

	[SupportedBy("Chrome")]
	public class SetDocumentCookieDisabledCommand: ICommand<SetDocumentCookieDisabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetDocumentCookieDisabled;
		/// <summary>
		/// Whether document.coookie API should be disabled.
		/// </summary>
		public bool Disabled { get; set; }
	}
}
