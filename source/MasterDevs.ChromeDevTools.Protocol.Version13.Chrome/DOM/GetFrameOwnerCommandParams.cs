using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns iframe node that owns iframe with the given domain.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetFrameOwnerCommandParams: ICommandParams<GetFrameOwnerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetFrameOwner;
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
