using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Returns a storage key given a frame id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetStorageKeyForFrameCommand: ICommand<GetStorageKeyForFrameCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.GetStorageKeyForFrame;
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
