using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Deletes browser cookies with matching name and url or domain/path pair.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DeleteCookiesCommandParams: ICommandParams<DeleteCookiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.DeleteCookies;
		/// <summary>
		/// Name of the cookies to remove.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// If specified, deletes all the cookies with the given name where domain and path match
		/// provided URL.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// If specified, deletes only cookies with the exact domain.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Domain { get; set; }
		/// <summary>
		/// If specified, deletes only cookies with the exact path.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Path { get; set; }
	}
}
