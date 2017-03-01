namespace IntercomInvitation.DomainModel
{
    // Represents Latitude & Longitude of a given co-ordinate.
    // See https://www.learner.org/jnorth/tm/LongitudeIntro.html
    // and also http://stackoverflow.com/questions/28068123/double-or-decimal-for-latitude-longitude-values-in-c-sharp.
    public class LatLong
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public LatLong() : this(0, 0)
        {
        }

        public LatLong(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public static LatLong operator -(LatLong lhs, LatLong rhs)
        {
            LatLong r = new LatLong();
            if (lhs != null && rhs != null)
            {
                r.Latitude = System.Math.Round(lhs.Latitude - rhs.Latitude, 6);
                r.Longitude = System.Math.Round(lhs.Longitude - rhs.Longitude, 6);
            }
            return r;
        }

        public override bool Equals(object obj)
        {
            bool areSame = false;
            LatLong toCompare = obj as LatLong;
            if (toCompare !=  null)
            {
                areSame = (Latitude == toCompare.Latitude && Longitude == toCompare.Longitude);
            }
            return areSame;
        }

        public override int GetHashCode()
        {
            // See http://stackoverflow.com/questions/371328/why-is-it-important-to-override-gethashcode-when-equals-method-is-overridden
            int hash = 13;
            hash = ((hash * 7) + Latitude.GetHashCode());
            hash = ((hash * 7) + Longitude.GetHashCode());
            return hash;
        }

        public override string ToString()
        {
            return string.Format("Latitude: {0}, Longitude: {1}", Latitude, Longitude);
        }
    }
}
