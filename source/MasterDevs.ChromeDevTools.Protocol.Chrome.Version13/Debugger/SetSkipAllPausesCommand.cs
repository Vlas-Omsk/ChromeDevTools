using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetSkipAllPausesCommand: ICommand<SetSkipAllPausesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetSkipAllPauses;
		/// <summary>
		/// New value for skip pauses state.
		/// </summary>
		public bool Skip { get; set; }
	}
}
