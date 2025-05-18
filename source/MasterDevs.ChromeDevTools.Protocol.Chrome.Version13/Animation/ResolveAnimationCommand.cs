using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Animation
{
	/// <summary>
	/// Gets the remote object of the Animation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResolveAnimationCommand: ICommand<ResolveAnimationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Animation.ResolveAnimation;
		/// <summary>
		/// Animation id.
		/// </summary>
		public string AnimationId { get; set; }
	}
}
