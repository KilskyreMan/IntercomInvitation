# Intercom Q3 - InviteCustomers
Given a list of customers (in a Json encoded text file), parse and display all customers who are within 100KM of Intercom's Dublin Office.

Build in Visual Studio 2015, .Net 4.
- Domain logic and executable contained in project IntercomInvitation.
- Unit Tests contained in IntercomInvitationTests.

General Approach
- Domain Logic & Entites confined under a sub folder called 'DomainModel'
 - Entity _LatLong_ contains Latitude / Longitude.
 - _Earth.DistanceBetween_ - logic for calculating distance in KM between two given points.
 - _CustomersToInvite_ - Encapsulates logic for filtering potential customers down to those within 100KM of Dublin Office
- Persistence
 - Logic (and DTO) for parsing customers.json and presenting a list of potential customers for later filtering.
 - Implements interface _ICustomerDB_
- View
 - Used a simple WinForms dialog to enable file selection and presentation of results.
 ![alt tag](https://github.com/KilskyreMan/Intercom_Q3_InviteCustomers/blob/master/IntercomInvite.png)

###Thanks to
- [Newtonsoft - Json] (http://www.newtonsoft.com/json)
- [StackOverflow] (http://stackoverflow.com/)
