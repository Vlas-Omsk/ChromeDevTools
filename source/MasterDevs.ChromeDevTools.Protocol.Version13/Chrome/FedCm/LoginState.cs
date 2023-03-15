using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm{
	/// <summary>
	/// Whether this is a sign-up or sign-in action for this account, i.e.
	/// whether this account has ever been used to sign in to this RP before.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LoginState
	{
			SignIn,
			SignUp,
	}
}
