using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// This method tries to lookup and populate exception details for a
	/// JavaScript Error object.
	/// Note that the stackTrace portion of the resulting exceptionDetails will
	/// only be populated if the Runtime domain was enabled at the time when the
	/// Error was thrown.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetExceptionDetailsCommandParams: ICommandParams<GetExceptionDetailsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.GetExceptionDetails;
		/// <summary>
		/// The error object for which to resolve the exception details.
		/// </summary>
		public string ErrorObjectId { get; set; }
	}
}
