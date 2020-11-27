using InvoiceAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceAPI.Data.Providers
{
    public interface IInvoiceProvider
    {
        IEnumerable<Invoice> GetInvoices();
    }
}
