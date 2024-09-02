using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Polls the next batch of computed style updates.
	/// </summary>

	[SupportedBy("Chrome")]
	public class TakeComputedStyleUpdatesCommandResult : ICommandResult
	{
		/// <summary>
		/// The list of node Ids that have their tracked computed styles updated.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
