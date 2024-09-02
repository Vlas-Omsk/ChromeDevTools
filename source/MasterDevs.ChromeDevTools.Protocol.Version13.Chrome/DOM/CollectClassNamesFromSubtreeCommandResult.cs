using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Collects class names for the node with given id and all of it's child nodes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CollectClassNamesFromSubtreeCommandResult : ICommandResult
	{
		/// <summary>
		/// Class name list.
		/// </summary>
		public string[] ClassNames { get; set; }
	}
}
