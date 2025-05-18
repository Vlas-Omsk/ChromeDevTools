using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Get Origin Trials on given frame.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetOriginTrialsCommand: ICommand<GetOriginTrialsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetOriginTrials;
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
