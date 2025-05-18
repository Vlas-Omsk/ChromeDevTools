using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{
	/// <summary>
	/// Tells whether emulation is supported.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CanEmulateCommand: ICommand<CanEmulateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.CanEmulate;
	}
}
