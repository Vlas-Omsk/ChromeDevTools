using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.IndexedDB
{
	/// <summary>
	/// Requests database with given name in given frame.
	/// </summary>

	[SupportedBy("IOS")]
	public class RequestDatabaseCommand: ICommand<RequestDatabaseCommandResult>
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
