using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Creates a new special "inspector" stylesheet in the frame with given <code>frameId</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class CreateStyleSheetCommandParams: ICommandParams<CreateStyleSheetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.CreateStyleSheet;
		/// <summary>
		/// Identifier of the frame where the new "inspector" stylesheet should be created.
		/// </summary>
		public string FrameId { get; set; }
	}
}
