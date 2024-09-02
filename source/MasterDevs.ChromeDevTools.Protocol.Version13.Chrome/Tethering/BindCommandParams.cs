using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Tethering
{
	/// <summary>
	/// Request browser port binding.
	/// </summary>

	[SupportedBy("Chrome")]
	public class BindCommandParams: ICommandParams<BindCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Tethering.Bind;
		/// <summary>
		/// Port number to bind.
		/// </summary>
		public long Port { get; set; }
	}
}
