using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.HeadlessExperimental
{
	/// <summary>
	/// Enables headless events for the target.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.HeadlessExperimental.Enable;
	}
}
