using NFive.SDK.Core.Helpers;
using NFive.SDK.Core.Models;
using StreetlifeRP.Character.Shared.Models;
using StreetlifeRP.Character.Shared.Models.Backstory;

namespace StreetlifeRP.Character.Server.Models
{
    public class Backstory : IdentityModel, IBackstory
    {
        public Hometown Hometown { get; set; }

		public Backstory()
        {
            Id = GuidGenerator.GenerateTimeBasedGuid();
        }
    }
}
