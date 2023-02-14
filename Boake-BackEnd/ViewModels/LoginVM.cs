using System.ComponentModel.DataAnnotations;

namespace Boake_BackEnd.ViewModels
{
    public class LoginVM
    {
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememerMe { get; set; }
    }
}
