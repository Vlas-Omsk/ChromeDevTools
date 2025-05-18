using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{

	[SupportedBy("Chrome")]
	public class GetAdScriptIdCommand: ICommand<GetAdScriptIdCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetAdScriptId;
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
