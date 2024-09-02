using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{
	/// <summary>
	/// ServiceWorker error message.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ServiceWorkerErrorMessage
	{
		/// <summary>
		/// ErrorMessage
		/// </summary>
		public string ErrorMessage { get; set; }
		/// <summary>
		/// RegistrationId
		/// </summary>
		public string RegistrationId { get; set; }
		/// <summary>
		/// VersionId
		/// </summary>
		public string VersionId { get; set; }
		/// <summary>
		/// SourceURL
		/// </summary>
		public string SourceURL { get; set; }
		/// <summary>
		/// LineNumber
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// ColumnNumber
		/// </summary>
		public long ColumnNumber { get; set; }
	}
}
