using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Mirrors `DOMCharacterDataModified` event.
	/// </summary>
	[Event(ProtocolName.DOM.CharacterDataModified)]
	[SupportedBy("Chrome")]
	public class CharacterDataModifiedEvent
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
