using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.IO
{
	/// <summary>
	/// Return UUID of Blob object specified by a remote object id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResolveBlobCommandParams: ICommandParams<ResolveBlobCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IO.ResolveBlob;
		/// <summary>
		/// Object id of a Blob object wrapper.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
