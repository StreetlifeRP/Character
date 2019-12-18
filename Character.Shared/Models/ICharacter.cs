using System;
using JetBrains.Annotations;
using NFive.SDK.Core.Models;

namespace StreetlifeRP.Character.Shared.Models
{
	[PublicAPI]
    public interface ICharacter : IIdentityModel
    {
		bool IsAlive { get; set; }
		int Health { get; set; }
		int Armour { get; set; }
		string Model { get; set; }
		string WalkingStyle { get; set; }
		Position Position { get; set; }
		DateTime? LastUpdated { get; set; }
    }
}
