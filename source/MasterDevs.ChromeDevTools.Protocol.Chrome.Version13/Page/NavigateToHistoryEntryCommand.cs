using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Navigates current page to the given history entry.
	/// </summary>

	[SupportedBy("Chrome")]
	public class NavigateToHistoryEntryCommand: ICommand<NavigateToHistoryEntryCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.NavigateToHistoryEntry;
		/// <summary>
		/// Unique id of the entry to navigate to.
		/// </summary>
		public long EntryId { get; set; }
	}
}
