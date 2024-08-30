using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	/// Requests database with given name in given frame.
	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestDatabase)]
	[SupportedBy("iOS")]
	public class RequestDatabaseCommand: ICommandParams<RequestDatabaseCommandResponse>
	{
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
