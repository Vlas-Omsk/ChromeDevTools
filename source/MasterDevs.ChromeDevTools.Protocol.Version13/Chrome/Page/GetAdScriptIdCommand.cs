using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[Command(ProtocolName.Page.GetAdScriptId)]
	[SupportedBy("Chrome")]
	public class GetAdScriptIdCommand: ICommandParams<GetAdScriptIdCommandResponse>
	{
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
