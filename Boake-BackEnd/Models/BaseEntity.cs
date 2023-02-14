using Microsoft.VisualBasic;
using System;

namespace Boake_BackEnd.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedTime { get; set; } 
        public DateTime UpdatedTime { get; set; }
        public DateTime DeletedTime { get; set; }

    }
}
