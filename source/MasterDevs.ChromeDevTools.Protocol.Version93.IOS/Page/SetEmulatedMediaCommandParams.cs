using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Emulates the given media for CSS media queries.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetEmulatedMediaCommandParams: ICommandParams<SetEmulatedMediaCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetEmulatedMedia;
		/// <summary>
		/// Media type to emulate. Empty string disables the override.
		/// </summary>
		public string Media { get; set; }
	}
}
