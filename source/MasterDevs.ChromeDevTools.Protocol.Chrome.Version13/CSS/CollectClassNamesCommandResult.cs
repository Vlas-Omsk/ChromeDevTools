using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
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
