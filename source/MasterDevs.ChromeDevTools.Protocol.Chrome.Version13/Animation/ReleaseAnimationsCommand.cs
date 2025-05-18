using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Animation
{
	/// <summary>
	/// Releases a set of animations to no longer be manipulated.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ReleaseAnimationsCommand: ICommand<ReleaseAnimationsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Animation.ReleaseAnimations;
		/// <summary>
		/// List of animation ids to seek.
		/// </summary>
		public string[] Animations { get; set; }
	}
}
