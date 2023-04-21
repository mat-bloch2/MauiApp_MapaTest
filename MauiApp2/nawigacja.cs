using Svg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2
{
    internal class nawigacja
    {

        public async Task<string> getlocation()
        {
            Location location = await Geolocation.Default.GetLastKnownLocationAsync();

            if (location != null)
                return$"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}";
            else
            return "not location";
        }
    }
}
