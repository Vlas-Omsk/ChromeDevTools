using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Tells whether emulation of network conditions is supported.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class CanEmulateNetworkConditionsCommandResult : ICommandResult
	{
		/// <summary>
		/// True if emulation of network conditions is supported.
		/// </summary>
		public bool Result { get; set; }
	}
}
