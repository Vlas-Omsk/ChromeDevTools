using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.IndexedDB
{
	/// <summary>
	/// Requests database names for given security origin.
	/// </summary>

	[SupportedBy("IOS")]
	public class RequestDatabaseNamesCommand: ICommand<RequestDatabaseNamesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IndexedDB.RequestDatabaseNames;
		/// <summary>
		/// Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
	}
}
