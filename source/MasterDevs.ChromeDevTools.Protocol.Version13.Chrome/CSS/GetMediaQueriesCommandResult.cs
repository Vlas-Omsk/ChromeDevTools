using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Returns all media queries parsed by the rendering engine.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetMediaQueriesCommandResult : ICommandResult
	{
		/// <summary>
		/// Medias
		/// </summary>
		public CSSMedia[] Medias { get; set; }
	}
}
