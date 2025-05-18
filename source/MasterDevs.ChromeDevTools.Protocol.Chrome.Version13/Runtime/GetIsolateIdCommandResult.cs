using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
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
