using System;

namespace InvoiceAPI
{
    public class Invoice
    {
        public DateTime Date { get; set; }

        public decimal Value { get; set; }
        public string Reference { get; set; }
    }
}
