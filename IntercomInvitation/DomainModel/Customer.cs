namespace IntercomInvitation.DomainModel
{
    /// <summary>
    /// Customer as represented in our domain model - Name, Id & GPS Coordinates.
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LatLong GpsCoord { get; set; }

        public Customer(int id, string name, LatLong gpsCoord)
        {
            Id = id;
            Name = name;
            GpsCoord = gpsCoord;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Id, Name);
        }
    }
}
