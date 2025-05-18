using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.BackgroundService
{
	/// <summary>
	/// A key-value pair for additional event information to pass along.
	/// </summary>
	[SupportedBy("Chrome")]
	public class EventMetadata
	{
		/// <summary>
		/// Key
		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// Value
		/// </summary>
		public string Value { get; set; }
	}
}
