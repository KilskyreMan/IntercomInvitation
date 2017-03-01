using IntercomInvitation.DomainModel;
using System.Collections.Generic;

namespace IntercomInvitation.Interface
{
    /// <summary>
    /// An abstract (interfaced) customer reader so as to allow unit testing of
    /// domain entity CustomersToInvite.
    /// </summary>
    public interface ICustomerDB
    {
        List<Customer> Customers { get; }
    }
}
