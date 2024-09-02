using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
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
