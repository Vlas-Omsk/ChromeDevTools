using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOMStorage
{

	[SupportedBy("IOS")]
	public class SetDOMStorageItemCommand: ICommand<SetDOMStorageItemCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMStorage.SetDOMStorageItem;
		/// <summary>
		/// StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
		/// <summary>
		/// Key
		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// Value
		/// </summary>
		public string Value { get; set; }
	}
}
