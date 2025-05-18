using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Returns file information for the given
	/// File wrapper.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetFileInfoCommand: ICommand<GetFileInfoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetFileInfo;
		/// <summary>
		/// JavaScript object id of the node wrapper.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
