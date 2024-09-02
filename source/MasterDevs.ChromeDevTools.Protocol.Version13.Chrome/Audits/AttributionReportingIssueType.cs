using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AttributionReportingIssueType
	{
			PermissionPolicyDisabled,
			UntrustworthyReportingOrigin,
			InsecureContext,
			InvalidHeader,
			InvalidRegisterTriggerHeader,
			InvalidEligibleHeader,
			TooManyConcurrentRequests,
			SourceAndTriggerHeaders,
			SourceIgnored,
			TriggerIgnored,
			OsSourceIgnored,
			OsTriggerIgnored,
			InvalidRegisterOsSourceHeader,
			InvalidRegisterOsTriggerHeader,
			WebAndOsHeaders,
	}
}
