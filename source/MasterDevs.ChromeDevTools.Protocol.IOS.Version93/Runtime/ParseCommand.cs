using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Runtime
{
	/// <summary>
	/// Parses JavaScript source code for errors.
	/// </summary>

	[SupportedBy("IOS")]
	public class ParseCommand: ICommand<ParseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.Parse;
		/// <summary>
		/// Source code to parse.
		/// </summary>
		public string Source { get; set; }
	}
}
