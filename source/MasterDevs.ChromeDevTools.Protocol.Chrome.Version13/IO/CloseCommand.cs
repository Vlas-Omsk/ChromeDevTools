using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.IO
{
	/// <summary>
	/// Close the stream, discard any temporary backing storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CloseCommand: ICommand<CloseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IO.Close;
		/// <summary>
		/// Handle of the stream to close.
		/// </summary>
		public string Handle { get; set; }
	}
}
