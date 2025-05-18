using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Get Permissions Policy state on given frame.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetPermissionsPolicyStateCommand: ICommand<GetPermissionsPolicyStateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetPermissionsPolicyState;
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
