using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM2.BL
{
    public class CustomerRepository
    {
        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;

            //foreach (var c in customerList)
            //{
            //    if (c.CustomerId == customerId)
            //    {
            //        foundCustomer = c;
            //        break;
            //    }
            //}
            //LINQ syntax
            //var query = from c in customerList
            //            where c.CustomerId == customerId
            //            select c;

            //foundCustomer = query.First();

            foundCustomer = customerList.FirstOrDefault(c =>
            c.CustomerId == customerId);// single line lambda

            //foundCustomer = customerList.FirstOrDefault(c =>
            //                {
            //                    Debug.WriteLine(c.LastName);
            //                    return c.CustomerId == customerId;
            //                });//multi line lambda

            //foundCustomer = customerList.Where(c =>
            //                      c.CustomerId == customerId)
            //                      .Skip(1)
            //                      .FirstOrDefault();

            return foundCustomer;
        }

        public IEnumerable<string> GetNames(List<Customer> customerList)
        {
            var query = customerList.Select(c => c.LastName + ", " + c.FirstName);
            return query;
        }

        public dynamic GetNamesAndEmail(List<Customer> customerList)
        {
            var query = customerList.Select(c => new
                            {
                                Name = c.LastName + c.FirstName,
                                c.EmailAddess
                            });
            foreach (var item in query)
            {
                Console.WriteLine(item.Name + ":" + item.EmailAddess);
            }
            return query;
        }//recommended use of anonymous types = add this code where you need it  
        //for example, put this code in the UI layer, and bind directly to the results of the query

        //public IEnumerable<Customer> GetOverdueCustomers(List<Customer> customerList)
        //{
        //    var query = customerList
        //                    .Select(c => c.InvoiceList
        //                                  .Where(i => (IsPaid ?? false) == false));
        //}

        public List<Customer> Retrieve()
        {

            InvoiceRepository invoiceRepository = new InvoiceRepository();

            List<Customer> custList = new List<Customer>
            {new Customer()
                { CustomerId = 1,
                  FirstName = "Frodo",
                  LastName = "Baggins",
                  EmailAddess = "fb@hob.me",
                  CustomerTypeId = 1,
                  InvoiceList = invoiceRepository.Retrieve(1)},
             new Customer()
                { CustomerId = 2,
                  FirstName = "Bilbo",
                  LastName = "Baggins",
                  EmailAddess = "bb@hob.me",
                  CustomerTypeId = null,
                  InvoiceList = invoiceRepository.Retrieve(2)},
             new Customer()
                { CustomerId = 3,
                  FirstName = "Samwise",
                  LastName = "Gamgee",
                  EmailAddess = "sg@hob.me",
                  CustomerTypeId = 1,
                  InvoiceList = invoiceRepository.Retrieve(3)},
             new Customer()
                { CustomerId = 4,
                  FirstName = "Rosie",
                  LastName = "Cotton",
                  EmailAddess = "rc@hob.com",
                  CustomerTypeId = 2,
                  InvoiceList = invoiceRepository.Retrieve(4)}
            };
            return custList;
        }

        public IEnumerable<Customer> RetrieveEmptyList()
        {
            return Enumerable.Repeat(new Customer(), 5);
        }

        public IEnumerable<Customer> SortByName (List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.LastName)
                            .ThenBy(c => c.FirstName);
        }

        public IEnumerable<Customer> SortByNameInReverse (List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.LastName)
            //                .ThenByDescending(c => c.FirstName);

            return SortByName(customerList).Reverse();
        }

        public IEnumerable<Customer> SortByType (List<Customer> customerList)
        {
            return customerList.OrderByDescending(c => c.CustomerTypeId.HasValue)
                                .ThenBy(c => c.CustomerTypeId);
        }
    }
}
