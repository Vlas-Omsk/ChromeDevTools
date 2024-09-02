using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Fired when <code>Document</code> has been totally updated. Node ids are no longer valid.
	/// </summary>
	[EventName(ProtocolName.DOM.DocumentUpdated)]
	[SupportedBy("IOS")]
	public class DocumentUpdatedEventParams : IEventParams
	{
	}
}
