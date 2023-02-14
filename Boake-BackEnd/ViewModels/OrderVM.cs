using Boake_BackEnd.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boake_BackEnd.ViewModels
{
    public class OrderVM
    { 
        [Required]
        [StringLength(maximumLength: 50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(maximumLength: 40)]
        public string CountryRegion { get; set; }
        [StringLength(maximumLength: 25)]
        public string Firstname { get; set; }
        [StringLength(maximumLength: 25)]
        public string Lastname { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Address { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Apartment { get; set; }

        [Required]
        [StringLength(maximumLength: 30)]
        public string City { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string State { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string ZipCode { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public List<BasketItem> BasketItems { get; set; }
    }
}
