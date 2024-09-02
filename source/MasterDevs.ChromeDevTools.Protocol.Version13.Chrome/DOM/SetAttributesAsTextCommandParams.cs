using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Sets attributes on element with given id. This method is useful when user edits some existing
	/// attribute value and types in several attribute name/value pairs.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAttributesAsTextCommandParams: ICommandParams<SetAttributesAsTextCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.SetAttributesAsText;
		/// <summary>
		/// Id of the element to set attributes for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Text with a number of attributes. Will parse this text using HTML parser.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Attribute name to replace with new attributes derived from text in case text parsed
		/// successfully.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
	}
}
