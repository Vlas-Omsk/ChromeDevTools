using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOMStorage
{

	[SupportedBy("IOS")]
	public class GetDOMStorageItemsCommandResult : ICommandResult
	{
		/// <summary>
		/// Entries
		/// </summary>
		public string[][] Entries { get; set; }
	}
}
