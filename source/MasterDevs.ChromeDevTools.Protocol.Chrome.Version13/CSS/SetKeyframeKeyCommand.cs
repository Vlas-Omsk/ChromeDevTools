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
	public class SetKeyframeKeyCommand: ICommand<SetKeyframeKeyCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.SetKeyframeKey;
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
