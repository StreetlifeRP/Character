namespace StreetlifeRP.Character.Shared.Models.Appearance
{
    public class Feature
    {
        public FeatureTypes Type { get; set; }
        public int Index { get; set; }
        public float Opacity { get; set; }
        public FeatureColourTypes ColourType { get; set; }
        public int ColourId { get; set; }
        public int SecondColourId { get; set; }
    }
}
