
using Nop.Core.Configuration;

namespace Bonner.Nop.Plugin.StoreLocationsMap
{
    public class StoreLocationsMapSettings : ISettings
    {
        public string GoogleMapAPIKey { get; set; }
        public string DistanceRadius { get; set; }
        public string MarkerColor { get; set; }
        public string MapImageSize { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}