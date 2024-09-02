using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Get Permissions Policy state on given frame.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetPermissionsPolicyStateCommandParams: ICommandParams<GetPermissionsPolicyStateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetPermissionsPolicyState;
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
