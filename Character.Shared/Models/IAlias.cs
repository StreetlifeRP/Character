using System;
using NFive.SDK.Core.Models;

namespace StreetlifeRP.Character.Shared.Models
{
    public interface IAlias : IIdentityModel
    {
		string FirstName { get; set; }
		string MiddleName { get; set; }
		string LastName { get; set; }
        string Gender { get; set; }
        DateTime DateOfBirth { get; set; }
    }
}
