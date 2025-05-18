using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
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
