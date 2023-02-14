using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boake_BackEnd.Models
{
    public class Bio : BaseEntity
    {
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string YouTube { get; set; }
        public string Pinterest { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string WhiteLogo { get; set; }
        [NotMapped]
        public IFormFile WhitePhotoFile { get; set; }
        public string WhiteLogoMedium { get; set; }
        [NotMapped]
        public IFormFile WhitePhotoMediumFile { get; set; }
    }
}