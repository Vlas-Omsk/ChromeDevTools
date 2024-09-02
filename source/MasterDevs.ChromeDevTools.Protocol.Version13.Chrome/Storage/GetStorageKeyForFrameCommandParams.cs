using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Returns a storage key given a frame id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetStorageKeyForFrameCommandParams: ICommandParams<GetStorageKeyForFrameCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.GetStorageKeyForFrame;
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
