using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Performance
{
	/// <summary>
	/// Sets time domain to use for collecting and reporting duration metrics.
	/// Note that this must be called before enabling metrics collection. Calling
	/// this method while metrics collection is enabled returns an error.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class SetTimeDomainCommandParams: ICommandParams<SetTimeDomainCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Performance.SetTimeDomain;
		/// <summary>
		/// Time domain
		/// </summary>
		public string TimeDomain { get; set; }
	}
}
