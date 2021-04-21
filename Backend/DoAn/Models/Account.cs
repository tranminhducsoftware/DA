using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Models.Context;
using System.ComponentModel.DataAnnotations;

namespace DoAn.Models
{
    public class Account :BaseEntity
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Role { get; set; }

        public bool isLocked { get; set; }

        public string Note { get; set; }
    }
}
