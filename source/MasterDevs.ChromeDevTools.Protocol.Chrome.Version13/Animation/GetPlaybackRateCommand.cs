using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Animation
{
	/// <summary>
	/// Gets the playback rate of the document timeline.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetPlaybackRateCommand: ICommand<GetPlaybackRateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Animation.GetPlaybackRate;
	}
}
