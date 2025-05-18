using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Schema
{
	/// <summary>
	/// Description of the protocol domain.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Domain
	{
		/// <summary>
		/// Domain name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Domain version.
		/// </summary>
		public string Version { get; set; }
	}
}
