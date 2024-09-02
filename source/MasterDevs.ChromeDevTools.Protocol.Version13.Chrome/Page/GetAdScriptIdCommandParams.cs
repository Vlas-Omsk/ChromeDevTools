using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{

	[SupportedBy("Chrome")]
	public class GetAdScriptIdCommandParams: ICommandParams<GetAdScriptIdCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetAdScriptId;
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
