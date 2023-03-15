using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	/// Data entry.
	/// </summary>
	[SupportedBy("iOS")]
	public class DataEntry
	{
		/// <summary>
		/// Key.
		/// </summary>
		public Runtime.RemoteObject Key { get; set; }
		/// <summary>
		/// Primary key.
		/// </summary>
		public Runtime.RemoteObject PrimaryKey { get; set; }
		/// <summary>
		/// Value.
		/// </summary>
		public Runtime.RemoteObject Value { get; set; }
	}
}
