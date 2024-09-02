using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
{
	/// <summary>
	/// Returns the current time of the an animation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCurrentTimeCommandParams: ICommandParams<GetCurrentTimeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Animation.GetCurrentTime;
		/// <summary>
		/// Id of animation.
		/// </summary>
		public string Id { get; set; }
	}
}
