using System;
using NFive.SDK.Core.Helpers;
using NFive.SDK.Core.Models;
using StreetlifeRP.Character.Shared.Models;

namespace StreetlifeRP.Character.Server.Models
{
    public class Alias : IdentityModel, IAlias
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

		public Alias()
        {
            Id = GuidGenerator.GenerateTimeBasedGuid();
        }
    }
}
