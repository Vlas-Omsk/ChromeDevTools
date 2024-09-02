using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
{
	/// <summary>
	/// Gets the remote object of the Animation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResolveAnimationCommandParams: ICommandParams<ResolveAnimationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Animation.ResolveAnimation;
		/// <summary>
		/// Animation id.
		/// </summary>
		public string AnimationId { get; set; }
	}
}
