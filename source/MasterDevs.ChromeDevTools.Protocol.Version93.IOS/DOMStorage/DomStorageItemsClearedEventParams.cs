using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOMStorage
{
	[EventName(ProtocolName.DOMStorage.DomStorageItemsCleared)]
	[SupportedBy("IOS")]
	public class DomStorageItemsClearedEventParams : IEventParams
	{
		/// <summary>
		/// StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
