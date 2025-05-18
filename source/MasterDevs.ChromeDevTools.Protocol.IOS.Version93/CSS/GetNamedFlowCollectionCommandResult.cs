using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
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
