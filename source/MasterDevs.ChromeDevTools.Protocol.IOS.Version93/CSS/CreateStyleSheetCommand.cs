using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
{
	/// <summary>
	/// Creates a new special "inspector" stylesheet in the frame with given <code>frameId</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class CreateStyleSheetCommand: ICommand<CreateStyleSheetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.CreateStyleSheet;
		/// <summary>
		/// Identifier of the frame where the new "inspector" stylesheet should be created.
		/// </summary>
		public string FrameId { get; set; }
	}
}
