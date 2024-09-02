using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Creates a new page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CreateTargetCommandResult : ICommandResult
	{
		/// <summary>
		/// The id of the page opened.
		/// </summary>
		public string TargetId { get; set; }
	}
}
