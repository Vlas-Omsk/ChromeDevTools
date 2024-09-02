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
	public class GetPlatformFontsForNodeCommandParams: ICommandParams<GetPlatformFontsForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetPlatformFontsForNode;
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
