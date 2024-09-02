using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Returns version information.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetVersionCommandResult : ICommandResult
	{
		/// <summary>
		/// Protocol version.
		/// </summary>
		public string ProtocolVersion { get; set; }
		/// <summary>
		/// Product name.
		/// </summary>
		public string Product { get; set; }
		/// <summary>
		/// Product revision.
		/// </summary>
		public string Revision { get; set; }
		/// <summary>
		/// User-Agent.
		/// </summary>
		public string UserAgent { get; set; }
		/// <summary>
		/// V8 version.
		/// </summary>
		public string JsVersion { get; set; }
	}
}
