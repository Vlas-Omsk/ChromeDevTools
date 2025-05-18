using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Audits{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SharedArrayBufferIssueType
	{
			TransferIssue,
			CreationIssue,
	}
}
