using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMStorage
{

	[SupportedBy("Chrome")]
	public class RemoveDOMStorageItemCommandParams: ICommandParams<RemoveDOMStorageItemCommandResult>
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
