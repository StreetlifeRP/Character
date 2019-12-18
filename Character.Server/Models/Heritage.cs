using NFive.SDK.Core.Helpers;
using NFive.SDK.Core.Models;
using StreetlifeRP.Character.Shared.Models;

namespace StreetlifeRP.Character.Server.Models
{
    public class Heritage : IdentityModel, IHeritage
    {
        public int Parent1 { get; set; }
        public int Parent2 { get; set; }
        public float Resemblance { get; set; }
        public float SkinTone { get; set; }

		public Heritage()
        {
            Id = GuidGenerator.GenerateTimeBasedGuid();
        }
    }
}
