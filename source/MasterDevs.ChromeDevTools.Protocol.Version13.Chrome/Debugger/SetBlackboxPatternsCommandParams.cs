using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Replace previous blackbox patterns with passed ones. Forces backend to skip stepping/pausing in
	/// scripts with url matching one of the patterns. VM will try to leave blackboxed script by
	/// performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBlackboxPatternsCommandParams: ICommandParams<SetBlackboxPatternsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetBlackboxPatterns;
		/// <summary>
		/// Array of regexps that will be used to check script url for blackbox state.
		/// </summary>
		public string[] Patterns { get; set; }
	}
}
