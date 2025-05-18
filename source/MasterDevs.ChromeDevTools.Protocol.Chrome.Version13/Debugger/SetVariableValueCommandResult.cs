using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Changes value of variable in a callframe. Object-based scopes are not supported and must be
	/// mutated manually.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetVariableValueCommandResult : ICommandResult
	{
	}
}
