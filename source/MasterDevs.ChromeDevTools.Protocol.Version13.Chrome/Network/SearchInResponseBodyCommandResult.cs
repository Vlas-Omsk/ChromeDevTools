using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Searches for given string in response content.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SearchInResponseBodyCommandResult : ICommandResult
	{
		/// <summary>
		/// List of search matches.
		/// </summary>
		public Debugger.SearchMatch[] Result { get; set; }
	}
}
