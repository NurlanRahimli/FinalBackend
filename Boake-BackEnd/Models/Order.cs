using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Boake_BackEnd.Models
{
    public class Order
    {
        public int Id { get; set; } 
      
        public string CountryRegion { get; set; } 
        public string Address { get; set; }
        public string Apartment { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Message { get; set; }

        public bool? Status { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; } 
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
