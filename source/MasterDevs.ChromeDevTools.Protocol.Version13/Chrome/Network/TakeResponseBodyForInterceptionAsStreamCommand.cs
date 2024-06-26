using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns a handle to the stream representing the response body. Note that after this command,
	/// the intercepted request can't be continued as is -- you either need to cancel it or to provide
	/// the response body. The stream only supports sequential read, IO.read will fail if the position
	/// is specified.
	/// </summary>
	[Command(ProtocolName.Network.TakeResponseBodyForInterceptionAsStream)]
	[SupportedBy("Chrome")]
	public class TakeResponseBodyForInterceptionAsStreamCommand: IProtocolCommand<TakeResponseBodyForInterceptionAsStreamCommandResponse>
	{
		/// <summary>
		/// InterceptionId
		/// </summary>
		public string InterceptionId { get; set; }
	}
}
