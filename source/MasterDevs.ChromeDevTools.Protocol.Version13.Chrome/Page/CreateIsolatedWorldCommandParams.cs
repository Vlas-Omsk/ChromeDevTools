using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Creates an isolated world for the given frame.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CreateIsolatedWorldCommandParams: ICommandParams<CreateIsolatedWorldCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.CreateIsolatedWorld;
		/// <summary>
		/// Id of the frame in which the isolated world should be created.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// An optional name which is reported in the Execution Context.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string WorldName { get; set; }
		/// <summary>
		/// Whether or not universal access should be granted to the isolated world. This is a powerful
		/// option, use with caution.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GrantUniveralAccess { get; set; }
	}
}
