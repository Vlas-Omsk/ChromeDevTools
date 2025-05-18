using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOMStorage
{

	[SupportedBy("Chrome")]
	public class RemoveDOMStorageItemCommand: ICommand<RemoveDOMStorageItemCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMStorage.RemoveDOMStorageItem;
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
