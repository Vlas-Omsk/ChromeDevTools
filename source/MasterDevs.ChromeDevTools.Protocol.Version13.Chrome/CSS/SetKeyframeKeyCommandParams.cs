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
	public class SetKeyframeKeyCommandParams: ICommandParams<SetKeyframeKeyCommandResult>
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
