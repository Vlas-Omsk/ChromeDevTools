using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Creates a new special "via-inspector" stylesheet in the frame with given `frameId`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CreateStyleSheetCommand: ICommand<CreateStyleSheetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.CreateStyleSheet;
		/// <summary>
		/// Identifier of the frame where "via-inspector" stylesheet should be created.
		/// </summary>
		public string FrameId { get; set; }
	}
}
