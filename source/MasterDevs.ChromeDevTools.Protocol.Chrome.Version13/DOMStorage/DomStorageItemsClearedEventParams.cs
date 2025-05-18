using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOMStorage
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
