using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns the Named Flows from the document.
	/// </summary>
	[Command(ProtocolName.CSS.GetNamedFlowCollection)]
	[SupportedBy("iOS")]
	public class GetNamedFlowCollectionCommand: ICommandParams<GetNamedFlowCollectionCommandResponse>
	{
		/// <summary>
		/// The document node id for which to get the Named Flow Collection.
		/// </summary>
		public long DocumentNodeId { get; set; }
	}
}
