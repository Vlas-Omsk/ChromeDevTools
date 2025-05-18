using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Clears storage for origin.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearDataForOriginCommand: ICommand<ClearDataForOriginCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.ClearDataForOrigin;
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
