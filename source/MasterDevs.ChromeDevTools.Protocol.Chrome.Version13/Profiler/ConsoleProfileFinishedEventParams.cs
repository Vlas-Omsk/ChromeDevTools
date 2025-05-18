using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Profiler
{
	[EventName(ProtocolName.Profiler.ConsoleProfileFinished)]
	[SupportedBy("Chrome")]
	public class ConsoleProfileFinishedEventParams : IEventParams
	{
		/// <summary>
		/// Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Location of console.profileEnd().
		/// </summary>
		public Debugger.Location Location { get; set; }
		/// <summary>
		/// Profile
		/// </summary>
		public Profile Profile { get; set; }
		/// <summary>
		/// Profile title passed as an argument to console.profile().
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }
	}
}
