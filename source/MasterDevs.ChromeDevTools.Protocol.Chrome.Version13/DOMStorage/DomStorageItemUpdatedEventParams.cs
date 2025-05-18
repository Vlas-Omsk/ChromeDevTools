using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOMStorage
{
	[EventName(ProtocolName.DOMStorage.DomStorageItemUpdated)]
	[SupportedBy("Chrome")]
	public class DomStorageItemUpdatedEventParams : IEventParams
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
		/// OldValue
		/// </summary>
		public string OldValue { get; set; }
		/// <summary>
		/// NewValue
		/// </summary>
		public string NewValue { get; set; }
	}
}
