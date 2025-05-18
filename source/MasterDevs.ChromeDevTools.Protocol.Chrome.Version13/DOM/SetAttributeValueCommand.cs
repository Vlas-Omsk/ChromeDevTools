using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Sets attribute for an element with given id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAttributeValueCommand: ICommand<SetAttributeValueCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.SetAttributeValue;
		/// <summary>
		/// Id of the element to set attribute for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Attribute name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Attribute value.
		/// </summary>
		public string Value { get; set; }
	}
}
