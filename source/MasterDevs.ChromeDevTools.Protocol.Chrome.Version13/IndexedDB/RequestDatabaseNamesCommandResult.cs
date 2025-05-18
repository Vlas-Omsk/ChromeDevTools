using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.IndexedDB
{
	/// <summary>
	/// Requests database names for given security origin.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RequestDatabaseNamesCommandResult : ICommandResult
	{
		/// <summary>
		/// Database names for origin.
		/// </summary>
		public string[] DatabaseNames { get; set; }
	}
}
