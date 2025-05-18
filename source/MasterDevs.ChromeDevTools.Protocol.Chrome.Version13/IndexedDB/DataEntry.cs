using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.IndexedDB
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
