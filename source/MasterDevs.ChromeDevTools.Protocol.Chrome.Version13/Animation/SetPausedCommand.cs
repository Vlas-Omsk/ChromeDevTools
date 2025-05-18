using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Animation
{
	/// <summary>
	/// Sets the paused state of a set of animations.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetPausedCommand: ICommand<SetPausedCommandResult>
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
