using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Clears storage for origin.
	/// </summary>
	[Command(ProtocolName.Storage.ClearDataForOrigin)]
	[SupportedBy("Chrome")]
	public class ClearDataForOriginCommand: ICommandParams<ClearDataForOriginCommandResponse>
	{
		/// <summary>
		/// Security origin.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Comma separated list of StorageType to clear.
		/// </summary>
		public string StorageTypes { get; set; }
	}
}
