using System;

namespace IntercomInvitation.DomainModel
{
    public static class Earth
    {
        private static double DegreeToRadian(double degree)
        {
            return Math.PI * degree / 180.0;
        }

        /// <summary>
        /// Given two positions (latitude/longitude) on Earth, 
        /// calculate the distance in kilometres between them.  
        /// </summary>
        public static double DistanceBetween(LatLong pointA, LatLong pointB)
        {
            double avgRadiusOfEarth = 6371.392896; //Radius of the earth differ, I'm taking the average.

            //Haversine formula
            //distance = R * 2 * aTan2 ( square root of A, square root of 1 - A )
            //                   where A = sinus squared (difference in latitude / 2) + (cosine of latitude 1 * cosine of latitude 2 * sinus squared (difference in longitude / 2))
            //                   and R = the circumference of the earth
            // Reference: http://stackoverflow.com/questions/1420045/how-to-find-distance-from-the-latitude-and-longitude-of-two-locations

            LatLong differenceIn = pointA - pointB;

            double differenceInLat = DegreeToRadian(differenceIn.Latitude);
            double differenceInLong = DegreeToRadian(differenceIn.Longitude);
            double aInnerFormula = Math.Cos(DegreeToRadian(pointA.Latitude)) 
                                   * Math.Cos(DegreeToRadian(pointB.Latitude)) 
                                   * Math.Sin(differenceInLong / 2) 
                                   * Math.Sin(differenceInLong / 2);
            double aFormula = (Math.Sin((differenceInLat) / 2) * Math.Sin((differenceInLat) / 2)) + (aInnerFormula);
            return(Math.Round(avgRadiusOfEarth * 2 * Math.Atan2(Math.Sqrt(aFormula), Math.Sqrt(1 - aFormula)), 1));
        }
    }
}
