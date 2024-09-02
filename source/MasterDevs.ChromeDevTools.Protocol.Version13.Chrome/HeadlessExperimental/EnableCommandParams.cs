using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Enables headless events for the target.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class EnableCommandParams: ICommandParams<EnableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.HeadlessExperimental.Enable;
	}
}
