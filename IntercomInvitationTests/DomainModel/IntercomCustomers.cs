using IntercomInvitation.DomainModel;
using IntercomInvitation.Interface;
using System.Collections.Generic;

namespace IntercomInvitationTests.DomainModel
{
    /// <summary>
    /// Sample customer.json file taken from Intercom.
    /// (for unit test purposes, apologies - its quick and dirty.)
    /// </summary>
    internal class IntercomCustomers : ICustomerDB
    {
        public List<Customer> Customers { get; private set; }

        public IntercomCustomers()
        {
            Customers = new List<Customer>()
            {
                new Customer(  12,  "Christina McArdle" , new LatLong(52.986375 ,-6.043701)),
                new Customer(  1 ,  "Alice Cahill"      , new LatLong(51.92893,-10.27699)),
                new Customer(  2 ,  "Ian McArdle"       , new LatLong(51.8856167,-10.4240951)),
                new Customer(  3 ,  "Jack Enright"      , new LatLong(52.3191841,-8.5072391)),
                new Customer(  28,  "Charlie Halligan"  , new LatLong(53.807778,-7.714444)),
                new Customer(  7 ,  "Frank Kehoe"       , new LatLong(53.4692815,-9.436036)),
                new Customer(  8 ,  "Eoin Ahearn"       , new LatLong(54.0894797,-6.18671)),
                new Customer(  26,  "Stephen McArdle"   , new LatLong(53.038056,-7.653889)),
                new Customer(  27,  "Enid Gallagher"    , new LatLong(54.1225,-8.143333)),
                new Customer(  6 ,  "Theresa Enright"   , new LatLong(53.1229599,-6.2705202)),
                new Customer(  9 ,  "Jack Dempsey"      , new LatLong(52.2559432,-7.1048927)),
                new Customer(  10,  "Georgina Gallagher", new LatLong(52.240382,-6.972413)),
                new Customer(  4 ,  "Ian Kehoe"         , new LatLong(53.2451022,-6.238335)),
                new Customer(  5 ,  "Nora Dempsey"      , new LatLong(53.1302756,-6.2397222)),
                new Customer(  11,  "Richard Finnegan"  , new LatLong(53.008769,-6.1056711)),
                new Customer(  31,  "Alan Behan"        , new LatLong(53.1489345,-6.8422408)),
                new Customer(  13,  "Olive Ahearn"      , new LatLong(53,-7)),
                new Customer(  14,  "Helen Cahill"      , new LatLong(51.999447,-9.742744)),
                new Customer(  15,  "Michael Ahearn"    , new LatLong(52.966,-6.463)),
                new Customer(  16,  "Ian Larkin"        , new LatLong(52.366037,-8.179118)),
                new Customer(  17,  "Patricia Cahill"   , new LatLong(54.180238,-5.920898)),
                new Customer(  39,  "Lisa Ahearn"       , new LatLong(53.0033946,-6.3877505)),
                new Customer(  18,  "Bob Larkin"        , new LatLong(52.228056,-7.915833)),
                new Customer(  24,  "Rose Enright"      , new LatLong(54.133333,-6.433333)),
                new Customer(  19,  "Enid Cahill"       , new LatLong(55.033,   -8.112)),
                new Customer(  20,  "Enid Enright"      , new LatLong(53.521111,-9.831111)),
                new Customer(  21,  "David Ahearn"      , new LatLong(51.802,-9.442)),
                new Customer(  22,  "Charlie McArdle"   , new LatLong(54.374208,-8.371639)),
                new Customer(  29,  "Oliver Ahearn"     , new LatLong(53.74452,-7.11167)),
                new Customer(  30,  "Nick Enright"      , new LatLong(53.761389,-7.2875)),
                new Customer(  23,  "Eoin Gallagher"    , new LatLong(54.080556,-6.361944)),
                new Customer(  25,  "David Behan"       , new LatLong(52.833502,-8.522366))
            };
        }
    }
}

