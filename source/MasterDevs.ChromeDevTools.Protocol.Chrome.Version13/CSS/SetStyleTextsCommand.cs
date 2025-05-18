using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Applies specified style edits one after another in the given order.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetStyleTextsCommand: ICommand<SetStyleTextsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.SetStyleTexts;
		/// <summary>
		/// Edits
		/// </summary>
		public StyleDeclarationEdit[] Edits { get; set; }
	}
}
