using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Get Permissions Policy state on given frame.
	/// </summary>
	[Command(ProtocolName.Page.GetPermissionsPolicyState)]
	[SupportedBy("Chrome")]
	public class GetPermissionsPolicyStateCommand: ICommandParams<GetPermissionsPolicyStateCommandResponse>
	{
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
