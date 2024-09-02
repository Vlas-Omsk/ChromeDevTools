using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
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
