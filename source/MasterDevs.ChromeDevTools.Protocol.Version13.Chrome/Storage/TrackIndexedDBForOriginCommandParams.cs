using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Registers origin to be notified when an update occurs to its IndexedDB.
	/// </summary>

	[SupportedBy("Chrome")]
	public class TrackIndexedDBForOriginCommandParams: ICommandParams<TrackIndexedDBForOriginCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.TrackIndexedDBForOrigin;
		/// <summary>
		/// Security origin.
		/// </summary>
		public string Origin { get; set; }
	}
}
