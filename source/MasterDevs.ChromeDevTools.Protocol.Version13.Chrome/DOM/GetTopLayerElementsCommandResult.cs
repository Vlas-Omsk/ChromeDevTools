using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns NodeIds of current top layer elements.
	/// Top layer is rendered closest to the user within a viewport, therefore its elements always
	/// appear on top of all other content.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetTopLayerElementsCommandResult : ICommandResult
	{
		/// <summary>
		/// NodeIds of top layer elements
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
