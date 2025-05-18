using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Modifies the keyframe rule key text.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetKeyframeKeyCommandResult : ICommandResult
	{
		/// <summary>
		/// The resulting key text after modification.
		/// </summary>
		public Value KeyText { get; set; }
	}
}
