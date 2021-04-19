using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Models.Context;
using System.ComponentModel.DataAnnotations;

namespace DoAn.Models
{
    public class User : BaseEntity
    {
        public int AccountId { get; set; }

        [Required]
        [MaxLength(250)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int Gender { get; set; }

        [Required]
        public int Age { get; set; }

        public string Job { get; set; }

        public string Avatar { get; set; }

        public string BackgroundAvatar { get; set; }

        public string NickName { get; set; }

        public string Slogan { get; set; }

        public int FieldId { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public string Role { get; set; }

        public string Pronouns { get; set; }
    }
}
