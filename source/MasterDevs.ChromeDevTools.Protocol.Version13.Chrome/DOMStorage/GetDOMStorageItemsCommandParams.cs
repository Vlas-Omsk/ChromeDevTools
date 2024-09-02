using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMStorage
{

	[SupportedBy("Chrome")]
	public class GetDOMStorageItemsCommandParams: ICommandParams<GetDOMStorageItemsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMStorage.GetDOMStorageItems;
		/// <summary>
		/// StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
