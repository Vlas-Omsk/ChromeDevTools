using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Registers origin to be notified when an update occurs to its IndexedDB.
	/// </summary>

	[SupportedBy("Chrome")]
	public class TrackIndexedDBForOriginCommand: ICommand<TrackIndexedDBForOriginCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.TrackIndexedDBForOrigin;
		/// <summary>
		/// Security origin.
		/// </summary>
		public string Origin { get; set; }
	}
}
