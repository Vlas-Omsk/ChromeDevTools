using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Returns the Named Flows from the document.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetNamedFlowCollectionCommandParams: ICommandParams<GetNamedFlowCollectionCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetNamedFlowCollection;
		/// <summary>
		/// The document node id for which to get the Named Flow Collection.
		/// </summary>
		public long DocumentNodeId { get; set; }
	}
}
