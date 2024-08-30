using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Navigates current page to the given history entry.
	/// </summary>
	[Command(ProtocolName.Page.NavigateToHistoryEntry)]
	[SupportedBy("Chrome")]
	public class NavigateToHistoryEntryCommand: ICommandParams<NavigateToHistoryEntryCommandResponse>
	{
		/// <summary>
		/// Unique id of the entry to navigate to.
		/// </summary>
		public long EntryId { get; set; }
	}
}
