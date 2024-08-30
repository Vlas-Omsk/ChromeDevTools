using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	[Command(ProtocolName.DOMStorage.GetDOMStorageItems)]
	[SupportedBy("iOS")]
	public class GetDOMStorageItemsCommand: ICommandParams<GetDOMStorageItemsCommandResponse>
	{
		/// <summary>
		/// StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
