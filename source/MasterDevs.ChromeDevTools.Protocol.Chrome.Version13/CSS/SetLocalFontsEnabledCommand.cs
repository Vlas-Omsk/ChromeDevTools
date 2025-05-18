using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Enables/disables rendering of local CSS fonts (enabled by default).
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetLocalFontsEnabledCommand: ICommand<SetLocalFontsEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.SetLocalFontsEnabled;
		/// <summary>
		/// Whether rendering of local fonts is enabled.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
