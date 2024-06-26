using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// An options object that may be extended later to better support CORS,
	/// CORB and streaming.
	/// </summary>
	[SupportedBy("Chrome")]
	public class LoadNetworkResourceOptions
	{
		/// <summary>
		/// DisableCache
		/// </summary>
		public bool DisableCache { get; set; }
		/// <summary>
		/// IncludeCredentials
		/// </summary>
		public bool IncludeCredentials { get; set; }
	}
}
