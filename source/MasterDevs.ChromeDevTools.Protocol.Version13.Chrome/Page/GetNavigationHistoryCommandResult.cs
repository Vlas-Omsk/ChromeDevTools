using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Returns navigation history for the current page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetNavigationHistoryCommandResult : ICommandResult
	{
		/// <summary>
		/// Index of the current navigation history entry.
		/// </summary>
		public long CurrentIndex { get; set; }
		/// <summary>
		/// Array of navigation history entries.
		/// </summary>
		public NavigationEntry[] Entries { get; set; }
	}
}
