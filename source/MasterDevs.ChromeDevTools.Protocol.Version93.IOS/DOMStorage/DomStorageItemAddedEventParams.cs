using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOMStorage
{
	[EventName(ProtocolName.DOMStorage.DomStorageItemAdded)]
	[SupportedBy("IOS")]
	public class DomStorageItemAddedEventParams : IEventParams
	{
		/// <summary>
		/// StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
		/// <summary>
		/// Key
		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// NewValue
		/// </summary>
		public string NewValue { get; set; }
	}
}
