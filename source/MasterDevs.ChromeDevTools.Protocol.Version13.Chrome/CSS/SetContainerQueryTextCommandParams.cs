using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Modifies the expression of a container query.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetContainerQueryTextCommandParams: ICommandParams<SetContainerQueryTextCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.SetContainerQueryText;
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Range
		/// </summary>
		public SourceRange Range { get; set; }
		/// <summary>
		/// Text
		/// </summary>
		public string Text { get; set; }
	}
}
