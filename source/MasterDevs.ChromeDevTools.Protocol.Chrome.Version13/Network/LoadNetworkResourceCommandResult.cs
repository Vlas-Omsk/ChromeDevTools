using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Fetches the resource and returns the content.
	/// </summary>

	[SupportedBy("Chrome")]
	public class LoadNetworkResourceCommandResult : ICommandResult
	{
		/// <summary>
		/// Resource
		/// </summary>
		public LoadNetworkResourcePageResult Resource { get; set; }
	}
}
