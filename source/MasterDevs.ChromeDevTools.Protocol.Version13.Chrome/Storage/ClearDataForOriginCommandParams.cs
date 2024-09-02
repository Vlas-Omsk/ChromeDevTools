using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Clears storage for origin.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearDataForOriginCommandParams: ICommandParams<ClearDataForOriginCommandResult>
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
