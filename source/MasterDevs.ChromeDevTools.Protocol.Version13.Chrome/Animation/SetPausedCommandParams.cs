using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
{
	/// <summary>
	/// Sets the paused state of a set of animations.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetPausedCommandParams: ICommandParams<SetPausedCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Animation.SetPaused;
		/// <summary>
		/// Animations to set the pause state of.
		/// </summary>
		public string[] Animations { get; set; }
		/// <summary>
		/// Paused state to set to.
		/// </summary>
		public bool Paused { get; set; }
	}
}
