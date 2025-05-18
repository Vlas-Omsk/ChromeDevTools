using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOMStorage
{

	[SupportedBy("Chrome")]
	public class ClearCommand: ICommand<ClearCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMStorage.Clear;
		/// <summary>
		/// StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
