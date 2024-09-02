using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.IndexedDB
{
	/// <summary>
	/// Requests database names for given security origin.
	/// </summary>

	[SupportedBy("IOS")]
	public class RequestDatabaseNamesCommandParams: ICommandParams<RequestDatabaseNamesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IndexedDB.RequestDatabaseNames;
		/// <summary>
		/// Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
	}
}
