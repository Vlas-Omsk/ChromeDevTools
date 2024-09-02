using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Applies specified style edits one after another in the given order.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetStyleTextsCommandParams: ICommandParams<SetStyleTextsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.SetStyleTexts;
		/// <summary>
		/// Edits
		/// </summary>
		public StyleDeclarationEdit[] Edits { get; set; }
	}
}
