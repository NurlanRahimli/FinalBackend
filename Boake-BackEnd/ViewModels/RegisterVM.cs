using System.ComponentModel.DataAnnotations;

namespace Boake_BackEnd.ViewModels
{
    public class RegisterVM
    {
        [Required, StringLength(200)]
        public string Firstname { get; set; }
        [Required, StringLength(200)]
        public string Username { get; set; }
        [Required, StringLength(200)]
        public string Lastname { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; } 
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string CheckPassword { get; set; }
    }
}
