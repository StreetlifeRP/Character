using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using NFive.SDK.Client.Commands;
using NFive.SDK.Client.Communications;
using NFive.SDK.Client.Events;
using NFive.SDK.Client.Interface;
using NFive.SDK.Client.Services;
using NFive.SDK.Core.Diagnostics;
using NFive.SDK.Core.Models.Player;
using StreetlifeRP.Character.Client.Overlays;
using StreetlifeRP.Character.Shared;

namespace StreetlifeRP.Character.Client
{
	[PublicAPI]
	public class CharacterService : Service
	{
		private Configuration config;
		private CharacterOverlay overlay;

		public CharacterService(ILogger logger, ITickManager ticks, ICommunicationManager comms, ICommandManager commands, IOverlayManager overlay, User user) : base(logger, ticks, comms, commands, overlay, user) { }

		public override async Task Started()
		{
			// Request server configuration
			this.config = await this.Comms.Event(CharacterEvents.Configuration).ToServer().Request<Configuration>();

			this.Logger.Debug($"From server config: {this.config.Example}");

			// Create overlay
			this.overlay = new CharacterOverlay(this.OverlayManager);

			// Attach a tick handler
			this.Ticks.On(OnTick);
		}

		private async Task OnTick()
		{
			this.Logger.Debug("Hello World!");
			// Do something every frame

			await Delay(TimeSpan.FromSeconds(1));
		}
	}
}
