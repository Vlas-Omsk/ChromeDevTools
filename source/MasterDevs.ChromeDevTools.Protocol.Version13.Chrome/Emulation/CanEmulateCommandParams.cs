using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Tells whether emulation is supported.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CanEmulateCommandParams: ICommandParams<CanEmulateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.CanEmulate;
	}
}
