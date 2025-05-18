using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{

	[SupportedBy("Chrome")]
	public class SetScrollbarsHiddenCommand: ICommand<SetScrollbarsHiddenCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetScrollbarsHidden;
		/// <summary>
		/// Whether scrollbars should be always hidden.
		/// </summary>
		public bool Hidden { get; set; }
	}
}
