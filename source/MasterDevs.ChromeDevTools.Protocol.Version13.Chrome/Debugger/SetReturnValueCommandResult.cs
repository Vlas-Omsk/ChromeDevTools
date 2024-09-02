using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Changes return value in top frame. Available only at return break position.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetReturnValueCommandResult : ICommandResult
	{
	}
}
