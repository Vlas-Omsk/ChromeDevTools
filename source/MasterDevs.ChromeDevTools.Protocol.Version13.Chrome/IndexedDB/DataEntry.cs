using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.IndexedDB
{
	/// <summary>
	/// Data entry.
	/// </summary>
	[SupportedBy("Chrome")]
	public class DataEntry
	{
		/// <summary>
		/// Key object.
		/// </summary>
		public Runtime.RemoteObject Key { get; set; }
		/// <summary>
		/// Primary key object.
		/// </summary>
		public Runtime.RemoteObject PrimaryKey { get; set; }
		/// <summary>
		/// Value object.
		/// </summary>
		public Runtime.RemoteObject Value { get; set; }
	}
}
