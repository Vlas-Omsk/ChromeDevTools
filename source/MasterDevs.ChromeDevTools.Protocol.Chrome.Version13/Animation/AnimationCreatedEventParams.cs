using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Animation
{
	/// <summary>
	/// Event for each animation that has been created.
	/// </summary>
	[EventName(ProtocolName.Animation.AnimationCreated)]
	[SupportedBy("Chrome")]
	public class AnimationCreatedEventParams : IEventParams
	{
		/// <summary>
		/// Id of the animation that was created.
		/// </summary>
		public string Id { get; set; }
	}
}
