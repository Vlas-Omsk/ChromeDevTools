using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	[Command(ProtocolName.DOMStorage.GetDOMStorageItems)]
	[SupportedBy("Chrome")]
	public class GetDOMStorageItemsCommand: IProtocolCommand<GetDOMStorageItemsCommandResponse>
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
