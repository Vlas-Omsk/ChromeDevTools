using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Requests information about platform fonts which we used to render child TextNodes in the given
	/// node.
	/// </summary>
	[Command(ProtocolName.CSS.GetPlatformFontsForNode)]
	[SupportedBy("Chrome")]
	public class GetPlatformFontsForNodeCommand: ICommandParams<GetPlatformFontsForNodeCommandResponse>
	{
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
