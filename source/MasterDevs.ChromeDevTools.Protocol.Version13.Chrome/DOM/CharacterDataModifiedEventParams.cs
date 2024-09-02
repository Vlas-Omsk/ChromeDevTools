using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Mirrors `DOMCharacterDataModified` event.
	/// </summary>
	[EventName(ProtocolName.DOM.CharacterDataModified)]
	[SupportedBy("Chrome")]
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
