using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOMStorage
{

	[SupportedBy("Chrome")]
	public class GetDOMStorageItemsCommand: ICommand<GetDOMStorageItemsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMStorage.GetDOMStorageItems;
		/// <summary>
		/// StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
