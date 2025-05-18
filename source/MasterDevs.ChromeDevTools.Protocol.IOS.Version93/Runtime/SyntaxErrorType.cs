using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Runtime{
	/// <summary>
	/// Syntax error type: "none" for no error, "irrecoverable" for unrecoverable errors, "unterminated-literal" for when there is an unterminated literal, "recoverable" for when the expression is unfinished but valid so far.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SyntaxErrorType
	{
			None,
			Irrecoverable,
			[EnumMember(Value = "unterminated-literal")]
			Unterminated_literal,
			Recoverable,
	}
}
