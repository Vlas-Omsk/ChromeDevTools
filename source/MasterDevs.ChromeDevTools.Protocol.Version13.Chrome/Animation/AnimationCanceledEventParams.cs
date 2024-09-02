using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
{
	/// <summary>
	/// Event for when an animation has been cancelled.
	/// </summary>
	[EventName(ProtocolName.Animation.AnimationCanceled)]
	[SupportedBy("Chrome")]
	public class AnimationCanceledEventParams : IEventParams
	{
		/// <summary>
		/// Id of the animation that was cancelled.
		/// </summary>
		public string Id { get; set; }
	}
}
