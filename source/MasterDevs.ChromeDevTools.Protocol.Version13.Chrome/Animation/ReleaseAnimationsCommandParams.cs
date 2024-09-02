using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
{
	/// <summary>
	/// Releases a set of animations to no longer be manipulated.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ReleaseAnimationsCommandParams: ICommandParams<ReleaseAnimationsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Animation.ReleaseAnimations;
		/// <summary>
		/// List of animation ids to seek.
		/// </summary>
		public string[] Animations { get; set; }
	}
}
