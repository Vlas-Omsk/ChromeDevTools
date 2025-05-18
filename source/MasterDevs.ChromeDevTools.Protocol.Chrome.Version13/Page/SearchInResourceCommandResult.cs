using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Searches for given string in resource content.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SearchInResourceCommandResult : ICommandResult
	{
		/// <summary>
		/// List of search matches.
		/// </summary>
		public Debugger.SearchMatch[] Result { get; set; }
	}
}
