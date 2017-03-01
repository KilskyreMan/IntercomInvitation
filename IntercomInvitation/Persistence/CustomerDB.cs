using System.Collections.Generic;
using IntercomInvitation.DomainModel;
using IntercomInvitation.Interface;
using System.IO;
using Newtonsoft.Json;

namespace IntercomInvitation.Persistence
{
    /// <summary>
    /// Our "client facing" reader for retrieving a list of customers from
    /// (in our case) a Json file containing a list of potential customers to invite.
    /// </summary>
    public class CustomerDB : ICustomerDB
    {
        private List<Customer> _customers;

        public CustomerDB(string pathToJsonFile)
        {
            _customers = new List<Customer>();
            try
            {
                using (StreamReader jsonStore = new StreamReader(pathToJsonFile))
                {
                    string content = jsonStore.ReadToEnd();

                    // Not ideal - assuming customers in json file are separated by '\n'.
                    string[] jsonCustomers = content.Split('\n');
                    foreach(string jsonCustomer in jsonCustomers)
                    {
                        jsonCustomerDTO customer = JsonConvert.DeserializeObject<jsonCustomerDTO>(jsonCustomer);
                        _customers.Add(new DomainModel.Customer(customer.user_id,
                                                                customer.name,
                                                                new LatLong(customer.latitude, customer.longitude)));
                    }
                }
            }
            catch
            { // Any errors/exception just return an empty list of customers.
                _customers.Clear();
            }
        }

        #region ICustomerDB implementation
        public List<Customer> Customers
        {
            get { return _customers; }
        }
        #endregion
    }
}
