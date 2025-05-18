using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network{
	/// <summary>
	/// The status of a Reporting API report.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReportStatus
	{
			Queued,
			Pending,
			MarkedForRemoval,
			Success,
	}
}
