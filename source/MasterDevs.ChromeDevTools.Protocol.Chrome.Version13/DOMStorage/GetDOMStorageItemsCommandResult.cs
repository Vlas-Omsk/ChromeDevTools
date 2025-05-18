using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOMStorage
{

	[SupportedBy("Chrome")]
	public class GetDOMStorageItemsCommandResult : ICommandResult
	{
		/// <summary>
		/// Entries
		/// </summary>
		public string[][] Entries { get; set; }
	}
}
