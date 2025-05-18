using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.LayerTree
{
	/// <summary>
	/// Provides the reasons why the given layer was composited.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CompositingReasonsCommandResult : ICommandResult
	{
		/// <summary>
		/// A list of strings specifying reasons for the given layer to become composited.
		/// </summary>
		public string[] CompositingReasons { get; set; }
		/// <summary>
		/// A list of strings specifying reason IDs for the given layer to become composited.
		/// </summary>
		public string[] CompositingReasonIds { get; set; }
	}
}
