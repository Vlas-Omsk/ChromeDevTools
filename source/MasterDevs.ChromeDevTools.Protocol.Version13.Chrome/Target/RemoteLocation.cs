using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	[SupportedBy("Chrome")]
	public class RemoteLocation
	{
		/// <summary>
		/// Host
		/// </summary>
		public string Host { get; set; }
		/// <summary>
		/// Port
		/// </summary>
		public long Port { get; set; }
	}
}
