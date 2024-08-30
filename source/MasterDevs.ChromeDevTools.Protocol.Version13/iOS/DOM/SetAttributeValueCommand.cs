using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Sets attribute for an element with given id.
	/// </summary>
	[Command(ProtocolName.DOM.SetAttributeValue)]
	[SupportedBy("iOS")]
	public class SetAttributeValueCommand: ICommandParams<SetAttributeValueCommandResponse>
	{
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
