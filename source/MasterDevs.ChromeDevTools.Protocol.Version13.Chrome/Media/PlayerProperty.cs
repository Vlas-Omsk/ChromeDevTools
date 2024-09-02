using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Media
{
	/// <summary>
	/// Corresponds to kMediaPropertyChange
	/// </summary>
	[SupportedBy("Chrome")]
	public class PlayerProperty
	{
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Value
		/// </summary>
		public string Value { get; set; }
	}
}
