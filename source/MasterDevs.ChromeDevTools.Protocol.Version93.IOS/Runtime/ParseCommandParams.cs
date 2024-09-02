using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Parses JavaScript source code for errors.
	/// </summary>

	[SupportedBy("IOS")]
	public class ParseCommandParams: ICommandParams<ParseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.Parse;
		/// <summary>
		/// Source code to parse.
		/// </summary>
		public string Source { get; set; }
	}
}
