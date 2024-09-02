using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOMStorage
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
