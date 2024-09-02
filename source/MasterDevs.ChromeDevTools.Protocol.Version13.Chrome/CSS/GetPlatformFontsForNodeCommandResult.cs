using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Requests information about platform fonts which we used to render child TextNodes in the given
	/// node.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetPlatformFontsForNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// Usage statistics for every employed platform font.
		/// </summary>
		public PlatformFontUsage[] Fonts { get; set; }
	}
}
