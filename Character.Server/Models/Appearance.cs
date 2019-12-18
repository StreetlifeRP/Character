using NFive.SDK.Core.Helpers;
using NFive.SDK.Core.Models;
using StreetlifeRP.Character.Shared.Models;
using StreetlifeRP.Character.Shared.Models.Appearance;

namespace StreetlifeRP.Character.Server.Models
{
    public class Appearance : IdentityModel, IAppearance
    {
        public int EyeColorId { get; set; }
        public int HairColorId { get; set; }
        public int HairHighlightColor { get; set; }

        public Feature Aging { get; set; }
        public Feature Beard { get; set; }
        public Feature Blush { get; set; }
        public Feature Blemishes { get; set; }
        public Feature Chest { get; set; }
        public Feature Complexion { get; set; }
        public Feature Eyebrows { get; set; }
        public Feature Lipstick { get; set; }
        public Feature Makeup { get; set; }
        public Feature MolesAndFreckles { get; set; }
        public Feature SunDamage { get; set; }

        public Appearance()
        {
            Id = GuidGenerator.GenerateTimeBasedGuid();

            Aging = new Feature();
            Beard = new Feature();
            Blemishes = new Feature();
            Blush = new Feature();
            Chest = new Feature();
            Complexion = new Feature();
            Eyebrows = new Feature();
            Lipstick = new Feature();
            Makeup = new Feature();
            MolesAndFreckles = new Feature();
            SunDamage = new Feature();
        }
    }
}
