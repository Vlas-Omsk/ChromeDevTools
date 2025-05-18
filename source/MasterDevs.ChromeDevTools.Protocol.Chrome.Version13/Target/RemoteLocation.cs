using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
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
