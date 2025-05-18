using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.IndexedDB
{
	/// <summary>
	/// Requests database with given name in given frame.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RequestDatabaseCommandResult : ICommandResult
	{
		/// <summary>
		/// Database with an array of object stores.
		/// </summary>
		public DatabaseWithObjectStores DatabaseWithObjectStores { get; set; }
	}
}
