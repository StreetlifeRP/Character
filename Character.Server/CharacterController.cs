using JetBrains.Annotations;
using NFive.SDK.Core.Diagnostics;
using NFive.SDK.Server.Communications;
using NFive.SDK.Server.Controllers;
using StreetlifeRP.Character.Shared;

namespace StreetlifeRP.Character.Server
{
	[PublicAPI]
	public class CharacterController : ConfigurableController<Configuration>
	{
		public CharacterController(ILogger logger, Configuration configuration, ICommunicationManager comms) : base(logger, configuration)
		{
			// Send configuration when requested
			comms.Event(CharacterEvents.Configuration).FromClients().OnRequest(e => e.Reply(Configuration));
		}
	}
}
