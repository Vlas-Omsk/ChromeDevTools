using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.IO
{
	/// <summary>
	/// Return UUID of Blob object specified by a remote object id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResolveBlobCommandResult : ICommandResult
	{
		/// <summary>
		/// UUID of the specified Blob.
		/// </summary>
		public string Uuid { get; set; }
	}
}
