using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.IndexedDB
{
	/// <summary>
	/// Database with an array of object stores.
	/// </summary>
	[SupportedBy("IOS")]
	public class DatabaseWithObjectStores
	{
		/// <summary>
		/// Database name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Database version.
		/// </summary>
		public double Version { get; set; }
		/// <summary>
		/// Object stores in this database.
		/// </summary>
		public ObjectStore[] ObjectStores { get; set; }
	}
}
