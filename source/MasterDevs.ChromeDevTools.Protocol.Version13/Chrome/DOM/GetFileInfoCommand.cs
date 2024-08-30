using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns file information for the given
	/// File wrapper.
	/// </summary>
	[Command(ProtocolName.DOM.GetFileInfo)]
	[SupportedBy("Chrome")]
	public class GetFileInfoCommand: ICommandParams<GetFileInfoCommandResponse>
	{
		/// <summary>
		/// JavaScript object id of the node wrapper.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
