using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Requests information about platform fonts which we used to render child TextNodes in the given
	/// node.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetPlatformFontsForNodeCommand: ICommand<GetPlatformFontsForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetPlatformFontsForNode;
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
