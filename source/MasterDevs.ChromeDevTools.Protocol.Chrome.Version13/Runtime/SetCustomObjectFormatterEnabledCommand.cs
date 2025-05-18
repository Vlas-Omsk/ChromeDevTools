using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
{

	[SupportedBy("Chrome")]
	public class SetCustomObjectFormatterEnabledCommand: ICommand<SetCustomObjectFormatterEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.SetCustomObjectFormatterEnabled;
		/// <summary>
		/// Enabled
		/// </summary>
		public bool Enabled { get; set; }
	}
}
