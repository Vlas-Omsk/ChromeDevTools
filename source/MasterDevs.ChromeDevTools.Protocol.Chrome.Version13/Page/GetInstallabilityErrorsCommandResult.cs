using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{

	[SupportedBy("Chrome")]
	public class GetInstallabilityErrorsCommandResult : ICommandResult
	{
		/// <summary>
		/// InstallabilityErrors
		/// </summary>
		public InstallabilityError[] InstallabilityErrors { get; set; }
	}
}
