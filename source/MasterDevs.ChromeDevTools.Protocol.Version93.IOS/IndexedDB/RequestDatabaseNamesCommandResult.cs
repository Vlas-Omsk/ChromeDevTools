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
	public class RequestDatabaseNamesCommandResult : ICommandResult
	{
		/// <summary>
		/// Database names for origin.
		/// </summary>
		public string[] DatabaseNames { get; set; }
	}
}
