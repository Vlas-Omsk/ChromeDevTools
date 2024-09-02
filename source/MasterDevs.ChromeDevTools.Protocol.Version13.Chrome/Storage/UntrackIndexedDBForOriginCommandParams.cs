using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Unregisters origin from receiving notifications for IndexedDB.
	/// </summary>

	[SupportedBy("Chrome")]
	public class UntrackIndexedDBForOriginCommandParams: ICommandParams<UntrackIndexedDBForOriginCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.UntrackIndexedDBForOrigin;
		/// <summary>
		/// Security origin.
		/// </summary>
		public string Origin { get; set; }
	}
}
