﻿namespace Lab11.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set;}
        public string InvoiceNumber { get; set; }
        public bool Total { get; set;}

        public int CustomerId { get; set;}
        public Customer Customer { get; set;}
    }
}
