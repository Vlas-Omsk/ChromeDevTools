using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Animation
{
	/// <summary>
	/// Event for animation that has been started.
	/// </summary>
	[EventName(ProtocolName.Animation.AnimationStarted)]
	[SupportedBy("Chrome")]
	public class AnimationStartedEventParams : IEventParams
	{
		/// <summary>
		/// Animation that was started.
		/// </summary>
		public Animation Animation { get; set; }
	}
}
