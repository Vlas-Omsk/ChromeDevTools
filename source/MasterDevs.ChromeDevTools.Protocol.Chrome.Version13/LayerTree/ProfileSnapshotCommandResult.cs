using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.LayerTree
{

	[SupportedBy("Chrome")]
	public class ProfileSnapshotCommandResult : ICommandResult
	{
		/// <summary>
		/// The array of paint profiles, one per run.
		/// </summary>
		public double[][] Timings { get; set; }
	}
}
