using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Modifies the keyframe rule key text.
	/// </summary>
	[Command(ProtocolName.CSS.SetKeyframeKey)]
	[SupportedBy("Chrome")]
	public class SetKeyframeKeyCommand: ICommandParams<SetKeyframeKeyCommandResponse>
	{
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Range
		/// </summary>
		public SourceRange Range { get; set; }
		/// <summary>
		/// KeyText
		/// </summary>
		public string KeyText { get; set; }
	}
}
