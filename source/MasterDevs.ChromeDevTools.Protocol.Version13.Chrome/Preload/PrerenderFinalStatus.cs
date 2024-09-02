using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Preload{
	/// <summary>
	/// List of FinalStatus reasons for Prerender2.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PrerenderFinalStatus
	{
			Activated,
			Destroyed,
			LowEndDevice,
			InvalidSchemeRedirect,
			InvalidSchemeNavigation,
			InProgressNavigation,
			NavigationRequestBlockedByCsp,
			MainFrameNavigation,
			MojoBinderPolicy,
			RendererProcessCrashed,
			RendererProcessKilled,
			Download,
			TriggerDestroyed,
			NavigationNotCommitted,
			NavigationBadHttpStatus,
			ClientCertRequested,
			NavigationRequestNetworkError,
			MaxNumOfRunningPrerendersExceeded,
			CancelAllHostsForTesting,
			DidFailLoad,
			Stop,
			SslCertificateError,
			LoginAuthRequested,
			UaChangeRequiresReload,
			BlockedByClient,
			AudioOutputDeviceRequested,
			MixedContent,
			TriggerBackgrounded,
			EmbedderTriggeredAndCrossOriginRedirected,
			MemoryLimitExceeded,
			FailToGetMemoryUsage,
			DataSaverEnabled,
			HasEffectiveUrl,
			ActivatedBeforeStarted,
			InactivePageRestriction,
			StartFailed,
			TimeoutBackgrounded,
			CrossSiteRedirect,
			CrossSiteNavigation,
			SameSiteCrossOriginRedirect,
			SameSiteCrossOriginRedirectNotOptIn,
			SameSiteCrossOriginNavigationNotOptIn,
			ActivationNavigationParameterMismatch,
			ActivatedInBackground,
			EmbedderHostDisallowed,
			ActivationNavigationDestroyedBeforeSuccess,
			TabClosedByUserGesture,
			TabClosedWithoutUserGesture,
			PrimaryMainFrameRendererProcessCrashed,
			PrimaryMainFrameRendererProcessKilled,
			ActivationFramePolicyNotCompatible,
			PreloadingDisabled,
			BatterySaverEnabled,
			ActivatedDuringMainFrameNavigation,
			PreloadingUnsupportedByWebContents,
	}
}
