using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{

	[SupportedBy("Chrome")]
	public class SetScrollbarsHiddenCommandParams: ICommandParams<SetScrollbarsHiddenCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetScrollbarsHidden;
		/// <summary>
		/// Whether scrollbars should be always hidden.
		/// </summary>
		public bool Hidden { get; set; }
	}
}
