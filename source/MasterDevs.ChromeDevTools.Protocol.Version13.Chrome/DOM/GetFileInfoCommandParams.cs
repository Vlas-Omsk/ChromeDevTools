using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns file information for the given
	/// File wrapper.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetFileInfoCommandParams: ICommandParams<GetFileInfoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetFileInfo;
		/// <summary>
		/// JavaScript object id of the node wrapper.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
