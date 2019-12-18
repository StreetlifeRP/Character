using System.Collections.Generic;
using JetBrains.Annotations;
using NFive.SDK.Core.Diagnostics;
using NFive.SDK.Server.Communications;
using NFive.SDK.Server.Controllers;
using CharacterSession = StreetlifeRP.Character.Server.Models.Session;
using StreetlifeRP.Character.Shared;
using NFive.SDK.Server.Events;
using NFiveSession = NFive.SDK.Core.Models.Player.Session;
using System.Threading.Tasks;
using System;
using StreetlifeRP.Character.Server.Storage;
using System.Linq;

namespace StreetlifeRP.Character.Server
{
	[PublicAPI]
	public class CharacterController : ConfigurableController<Configuration>
	{
        private readonly ILogger logger;
        private readonly ICommunicationManager communicationManager;
        private readonly List<CharacterSession> sessions = new List<CharacterSession>();

		public CharacterController(
			ILogger logger,
			Configuration configuration,
			ICommunicationManager communication) : base(logger, configuration)
		{
            this.logger = logger;
            communicationManager = communication;

			// Listen for configuration requests.
            communicationManager
				.Event(CharacterEvents.Configuration)
                .FromClients()
				.OnRequest(callback => callback.Reply(configuration));

            // Listen for NFive disconnect event.
            communicationManager.Event(SessionEvents.ClientDisconnected)
                .FromServer()
                .On<IClient, NFiveSession>(OnClientDisconnected);

		}

		private void OnClientDisconnected(ICommunicationMessage message,
			IClient client, NFiveSession session)
        {
        }
	}
}
