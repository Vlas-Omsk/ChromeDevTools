using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Animation
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
