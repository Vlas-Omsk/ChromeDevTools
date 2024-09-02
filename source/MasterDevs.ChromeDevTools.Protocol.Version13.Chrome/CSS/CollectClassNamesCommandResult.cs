using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Returns all class names from specified stylesheet.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CollectClassNamesCommandResult : ICommandResult
	{
		/// <summary>
		/// Class name list.
		/// </summary>
		public string[] ClassNames { get; set; }
	}
}
