using NFive.SDK.Core.Models;
using StreetlifeRP.Character.Shared.Models.Backstory;

namespace StreetlifeRP.Character.Shared.Models
{
    public interface IBackstory : IIdentityModel
    {
		Hometown Hometown { get; set; }
    }
}
