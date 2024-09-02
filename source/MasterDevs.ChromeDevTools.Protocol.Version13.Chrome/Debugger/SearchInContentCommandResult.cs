using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Searches for given string in script content.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SearchInContentCommandResult : ICommandResult
	{
		/// <summary>
		/// List of search matches.
		/// </summary>
		public SearchMatch[] Result { get; set; }
	}
}
