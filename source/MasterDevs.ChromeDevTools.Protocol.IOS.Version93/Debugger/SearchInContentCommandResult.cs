using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
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
