using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Navigates current page to the given history entry.
	/// </summary>

	[SupportedBy("Chrome")]
	public class NavigateToHistoryEntryCommandParams: ICommandParams<NavigateToHistoryEntryCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.NavigateToHistoryEntry;
		/// <summary>
		/// Unique id of the entry to navigate to.
		/// </summary>
		public long EntryId { get; set; }
	}
}
