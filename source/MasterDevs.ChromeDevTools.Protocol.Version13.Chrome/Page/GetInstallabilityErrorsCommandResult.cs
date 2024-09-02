using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
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
