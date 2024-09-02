using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns file information for the given
	/// File wrapper.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetFileInfoCommandResult : ICommandResult
	{
		/// <summary>
		/// Path
		/// </summary>
		public string Path { get; set; }
	}
}
