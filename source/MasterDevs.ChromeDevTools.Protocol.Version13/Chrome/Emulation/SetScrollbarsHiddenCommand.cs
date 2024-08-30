using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	[Command(ProtocolName.Emulation.SetScrollbarsHidden)]
	[SupportedBy("Chrome")]
	public class SetScrollbarsHiddenCommand: ICommandParams<SetScrollbarsHiddenCommandResponse>
	{
		/// <summary>
		/// Whether scrollbars should be always hidden.
		/// </summary>
		public bool Hidden { get; set; }
	}
}
