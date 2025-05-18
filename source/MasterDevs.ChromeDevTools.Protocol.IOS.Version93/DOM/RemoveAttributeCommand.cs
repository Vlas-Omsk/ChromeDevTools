using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
{
	/// <summary>
	/// Removes attribute with given name from an element with given id.
	/// </summary>

	[SupportedBy("IOS")]
	public class RemoveAttributeCommand: ICommand<RemoveAttributeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.RemoveAttribute;
		/// <summary>
		/// Id of the element to remove attribute from.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Name of the attribute to remove.
		/// </summary>
		public string Name { get; set; }
	}
}
