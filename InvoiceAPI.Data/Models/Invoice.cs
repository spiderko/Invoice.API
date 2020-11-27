using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceAPI.Data.Models
{
    public class Invoice
    {
        public DateTime Date { get; set; }

        public decimal Value { get; set; }
        public string Reference { get; set; }
    }
}
