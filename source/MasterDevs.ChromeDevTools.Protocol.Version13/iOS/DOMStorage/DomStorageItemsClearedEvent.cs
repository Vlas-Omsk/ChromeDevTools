using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	[Event(ProtocolName.DOMStorage.DomStorageItemsCleared)]
	[SupportedBy("iOS")]
	public class DomStorageItemsClearedEvent
	{
		/// <summary>
		/// StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
