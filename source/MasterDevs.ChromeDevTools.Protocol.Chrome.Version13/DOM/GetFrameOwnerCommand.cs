using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Returns iframe node that owns iframe with the given domain.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetFrameOwnerCommand: ICommand<GetFrameOwnerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetFrameOwner;
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
