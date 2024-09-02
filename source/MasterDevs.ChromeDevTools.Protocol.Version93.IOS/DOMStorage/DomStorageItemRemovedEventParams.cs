using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOMStorage
{
	[EventName(ProtocolName.DOMStorage.DomStorageItemRemoved)]
	[SupportedBy("IOS")]
	public class DomStorageItemRemovedEventParams : IEventParams
	{
		/// <summary>
		/// StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
		/// <summary>
		/// Key
		/// </summary>
		public string Key { get; set; }
	}
}
