using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Tethering
{
	/// <summary>
	/// Request browser port binding.
	/// </summary>

	[SupportedBy("Chrome")]
	public class BindCommand: ICommand<BindCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Tethering.Bind;
		/// <summary>
		/// Port number to bind.
		/// </summary>
		public long Port { get; set; }
	}
}
