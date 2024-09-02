using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.IndexedDB
{
	/// <summary>
	/// Requests database with given name in given frame.
	/// </summary>

	[SupportedBy("IOS")]
	public class RequestDatabaseCommandParams: ICommandParams<RequestDatabaseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IndexedDB.RequestDatabase;
		/// <summary>
		/// Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Database name.
		/// </summary>
		public string DatabaseName { get; set; }
	}
}
