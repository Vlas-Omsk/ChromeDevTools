using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Mirrors <code>DOMCharacterDataModified</code> event.
	/// </summary>
	[EventName(ProtocolName.DOM.CharacterDataModified)]
	[SupportedBy("IOS")]
	public class CharacterDataModifiedEventParams : IEventParams
	{
		/// <summary>
		/// Id of the node that has changed.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// New text value.
		/// </summary>
		public string CharacterData { get; set; }
	}
}
