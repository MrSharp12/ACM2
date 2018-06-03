using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM2.BL
{
    public class InvoiceRepository
    {
        /// <summary>
        /// Retrieves the list of invoices
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public List<Invoice> Retrieve(int customerId)
        {
            List<Invoice> invoiceList = new List<Invoice>
                    {new Invoice()
                            { InvoiceId = 1,
                              CustomerId = 1,
                              InvoiceDate = new DateTime(2013, 6, 20),
                              DueDate = new DateTime(2013, 8, 29),
                              IsPaid = null},
                     new Invoice()
                            { InvoiceId = 2,
                              CustomerId = 1,
                              InvoiceDate = new DateTime(2013, 7, 20),
                              DueDate = new DateTime(2013, 8, 20),
                              IsPaid = null},
                    };

            List<Invoice> filteredList = invoiceList.Where(i => i.CustomerId == customerId).ToList();

            return filteredList;
        }
    }
}
