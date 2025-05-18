using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Animation
{
	/// <summary>
	/// Returns the current time of the an animation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCurrentTimeCommand: ICommand<GetCurrentTimeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Animation.GetCurrentTime;
		/// <summary>
		/// Id of animation.
		/// </summary>
		public string Id { get; set; }
	}
}
