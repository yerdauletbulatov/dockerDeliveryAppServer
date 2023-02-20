namespace ApplicationCore.Entities.AppEntities.Locations
{
    public class Location : BaseEntity
    {
        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        
    }
}