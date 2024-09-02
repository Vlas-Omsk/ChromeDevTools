using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Get Origin Trials on given frame.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetOriginTrialsCommandParams: ICommandParams<GetOriginTrialsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetOriginTrials;
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
