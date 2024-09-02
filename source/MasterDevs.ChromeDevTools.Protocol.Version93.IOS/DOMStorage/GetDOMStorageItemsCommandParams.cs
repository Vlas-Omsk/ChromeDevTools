using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOMStorage
{

	[SupportedBy("IOS")]
	public class GetDOMStorageItemsCommandParams: ICommandParams<GetDOMStorageItemsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMStorage.GetDOMStorageItems;
		/// <summary>
		/// StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
