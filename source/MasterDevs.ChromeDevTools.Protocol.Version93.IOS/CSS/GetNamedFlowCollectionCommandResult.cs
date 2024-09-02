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
	public class GetNamedFlowCollectionCommandResult : ICommandResult
	{
		/// <summary>
		/// An array containing the Named Flows in the document.
		/// </summary>
		public NamedFlow[] NamedFlows { get; set; }
	}
}
