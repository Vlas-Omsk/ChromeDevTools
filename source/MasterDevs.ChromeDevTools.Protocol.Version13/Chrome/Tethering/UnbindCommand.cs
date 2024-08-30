using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tethering
{
	/// <summary>
	/// Request browser port unbinding.
	/// </summary>
	[Command(ProtocolName.Tethering.Unbind)]
	[SupportedBy("Chrome")]
	public class UnbindCommand: ICommandParams<UnbindCommandResponse>
	{
		/// <summary>
		/// Port number to unbind.
		/// </summary>
		public long Port { get; set; }
	}
}
