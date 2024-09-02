using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Tethering
{
	/// <summary>
	/// Request browser port unbinding.
	/// </summary>

	[SupportedBy("Chrome")]
	public class UnbindCommandParams: ICommandParams<UnbindCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Tethering.Unbind;
		/// <summary>
		/// Port number to unbind.
		/// </summary>
		public long Port { get; set; }
	}
}
