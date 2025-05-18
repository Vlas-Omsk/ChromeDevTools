using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Security
{
	/// <summary>
	/// Enables tracking security state changes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Security.Enable;
	}
}
