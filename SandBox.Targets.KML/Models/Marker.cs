using SharpKml.Base;
using SharpKml.Dom;

namespace SandBox.KML.Models
{
    public class Marker
    {
        private Placemark _placemark;
        public Placemark Placemark
        {
            get
            {
                return _placemark;
            }
        }

        public Marker(string name, Coordinates coordinates)
        {
            _placemark = new Placemark();
            _placemark.Name = name;
            SetPoint(coordinates.Latitude, coordinates.Longitude, coordinates.Altitude);
        }

        private void SetPoint(double latitude, double longitude, double altitude = 0)
        {
            _placemark.Geometry = new Point
            {
                Coordinate = new Vector(latitude, longitude, altitude)
            };
        }
    }
}
