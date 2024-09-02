using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOMStorage
{
	/// <summary>
	/// DOM Storage identifier.
	/// </summary>
	[SupportedBy("IOS")]
	public class StorageId
	{
		/// <summary>
		/// Security origin for the storage.
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Whether the storage is local storage (not session storage).
		/// </summary>
		public bool IsLocalStorage { get; set; }
	}
}
