using InvoiceAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceAPI.Data.Providers
{
    public class InvoiceProvider : IInvoiceProvider
    {
        public IEnumerable<Invoice> GetInvoices()
        {
            throw new NotImplementedException();
        }
    }
}
