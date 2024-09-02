using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOMStorage
{

	[SupportedBy("IOS")]
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
