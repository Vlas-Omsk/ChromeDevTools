using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{

	[SupportedBy("Chrome")]
	public class SetCustomObjectFormatterEnabledCommandParams: ICommandParams<SetCustomObjectFormatterEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.SetCustomObjectFormatterEnabled;
		/// <summary>
		/// Enabled
		/// </summary>
		public bool Enabled { get; set; }
	}
}
