using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Searches for given string in resource content.
	/// </summary>

	[SupportedBy("IOS")]
	public class SearchInResourceCommandResult : ICommandResult
	{
		/// <summary>
		/// List of search matches.
		/// </summary>
		public GenericTypes.SearchMatch[] Result { get; set; }
	}
}
