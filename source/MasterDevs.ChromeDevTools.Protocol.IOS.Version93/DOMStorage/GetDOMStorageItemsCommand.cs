using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOMStorage
{

	[SupportedBy("IOS")]
	public class GetDOMStorageItemsCommand: ICommand<GetDOMStorageItemsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMStorage.GetDOMStorageItems;
		/// <summary>
		/// StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
