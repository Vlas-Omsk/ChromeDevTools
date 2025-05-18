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
	public class GetPermissionsPolicyStateCommandResult : ICommandResult
	{
		/// <summary>
		/// States
		/// </summary>
		public PermissionsPolicyFeatureState[] States { get; set; }
	}
}
