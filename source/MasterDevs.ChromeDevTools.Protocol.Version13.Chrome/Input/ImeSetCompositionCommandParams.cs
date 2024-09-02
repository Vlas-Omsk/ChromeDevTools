using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Input
{
	/// <summary>
	/// This method sets the current candidate text for ime.
	/// Use imeCommitComposition to commit the final text.
	/// Use imeSetComposition with empty string as text to cancel composition.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ImeSetCompositionCommandParams: ICommandParams<ImeSetCompositionCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Input.ImeSetComposition;
		/// <summary>
		/// The text to insert
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// selection start
		/// </summary>
		public long SelectionStart { get; set; }
		/// <summary>
		/// selection end
		/// </summary>
		public long SelectionEnd { get; set; }
		/// <summary>
		/// replacement start
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ReplacementStart { get; set; }
		/// <summary>
		/// replacement end
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ReplacementEnd { get; set; }
	}
}
