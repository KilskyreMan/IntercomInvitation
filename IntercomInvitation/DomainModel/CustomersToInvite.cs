using IntercomInvitation.Interface;
using System.Collections.Generic;

namespace IntercomInvitation.DomainModel
{
    /// <summary>
    /// Given a list of potential customers, give back list of customers living within 100Km
    /// of the Dublin Office.
    /// Customers to be sorted by UserID (ascending).
    /// </summary>
    public static class CustomersToInvite
    {
        public static List<Customer> LivingWithin100Km(ICustomerDB potentialCustomers)
        {
            LatLong DublinOffice = new LatLong(53.3393, -6.2576841);

            List<Customer> customers = new List<Customer>();
            foreach(Customer customer in potentialCustomers.Customers)
            {
                if (Earth.DistanceBetween(DublinOffice, customer.GpsCoord) <= 100.00)
                {
                    customers.Add(customer);
                }
            }

            customers.Sort((left, right) => left.Id.CompareTo(right.Id));

            return customers;
        }
    }
}
