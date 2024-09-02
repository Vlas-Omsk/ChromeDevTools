using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Searches for given string in script content.
	/// </summary>

	[SupportedBy("IOS")]
	public class SearchInContentCommandResult : ICommandResult
	{
		/// <summary>
		/// List of search matches.
		/// </summary>
		public GenericTypes.SearchMatch[] Result { get; set; }
	}
}
