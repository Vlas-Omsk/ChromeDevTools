using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
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
