using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.IO
{
	/// <summary>
	/// Close the stream, discard any temporary backing storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CloseCommandParams: ICommandParams<CloseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IO.Close;
		/// <summary>
		/// Handle of the stream to close.
		/// </summary>
		public string Handle { get; set; }
	}
}
