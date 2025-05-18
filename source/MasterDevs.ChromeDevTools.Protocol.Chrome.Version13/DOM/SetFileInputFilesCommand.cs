using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Sets files for the given file input element.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetFileInputFilesCommand: ICommand<SetFileInputFilesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.SetFileInputFiles;
		/// <summary>
		/// Array of file paths to set.
		/// </summary>
		public string[] Files { get; set; }
		/// <summary>
		/// Identifier of the node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Identifier of the backend node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// JavaScript object id of the node wrapper.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}
