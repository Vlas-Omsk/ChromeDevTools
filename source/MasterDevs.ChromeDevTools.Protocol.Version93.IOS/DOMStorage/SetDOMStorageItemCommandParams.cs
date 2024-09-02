using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOMStorage
{

	[SupportedBy("IOS")]
	public class SetDOMStorageItemCommandParams: ICommandParams<SetDOMStorageItemCommandResult>
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
