using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMStorage
{
	[EventName(ProtocolName.DOMStorage.DomStorageItemsCleared)]
	[SupportedBy("Chrome")]
	public class DomStorageItemsClearedEventParams : IEventParams
	{
		/// <summary>
		/// StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
