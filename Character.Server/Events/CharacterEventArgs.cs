using System;
using JetBrains.Annotations;
using CharacterModel = StreetlifeRP.Character.Server.Models.Character;

namespace StreetlifeRP.Character.Server.Events
{
	[PublicAPI]
    public class CharacterEventArgs : EventArgs
    {
		public CharacterModel Character { get; }

		public CharacterEventArgs(CharacterModel character)
        {
            Character = character;
        }
    }
}
