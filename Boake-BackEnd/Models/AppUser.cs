using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Boake_BackEnd.Models
{
    public class AppUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
