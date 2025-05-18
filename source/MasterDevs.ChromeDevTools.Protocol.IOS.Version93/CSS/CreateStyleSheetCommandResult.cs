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
	public class CreateStyleSheetCommandResult : ICommandResult
	{
		/// <summary>
		/// Identifier of the created "inspector" stylesheet.
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
