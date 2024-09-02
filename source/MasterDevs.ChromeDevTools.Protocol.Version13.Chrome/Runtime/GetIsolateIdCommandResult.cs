using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Returns the isolate id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetIsolateIdCommandResult : ICommandResult
	{
		/// <summary>
		/// The isolate id.
		/// </summary>
		public string Id { get; set; }
	}
}
