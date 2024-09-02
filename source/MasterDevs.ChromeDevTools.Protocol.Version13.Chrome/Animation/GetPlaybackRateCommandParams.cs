using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
{
	/// <summary>
	/// Gets the playback rate of the document timeline.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetPlaybackRateCommandParams: ICommandParams<GetPlaybackRateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Animation.GetPlaybackRate;
	}
}
