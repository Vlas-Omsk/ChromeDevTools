using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.IndexedDB
{
	/// <summary>
	/// Object store.
	/// </summary>
	[SupportedBy("IOS")]
	public class ObjectStore
	{
		/// <summary>
		/// Object store name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Object store key path.
		/// </summary>
		public KeyPath KeyPath { get; set; }
		/// <summary>
		/// If true, object store has auto increment flag set.
		/// </summary>
		public bool AutoIncrement { get; set; }
		/// <summary>
		/// Indexes in this object store.
		/// </summary>
		public ObjectStoreIndex[] Indexes { get; set; }
	}
}
