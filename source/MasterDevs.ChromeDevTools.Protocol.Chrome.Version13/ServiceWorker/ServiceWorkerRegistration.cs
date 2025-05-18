using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.ServiceWorker
{
	/// <summary>
	/// ServiceWorker registration.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ServiceWorkerRegistration
	{
		/// <summary>
		/// RegistrationId
		/// </summary>
		public string RegistrationId { get; set; }
		/// <summary>
		/// ScopeURL
		/// </summary>
		public string ScopeURL { get; set; }
		/// <summary>
		/// IsDeleted
		/// </summary>
		public bool IsDeleted { get; set; }
	}
}
