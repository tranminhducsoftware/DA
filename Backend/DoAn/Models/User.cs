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
        [Required]
        public string Email { get; set; }

        public string FullName { get; set; }

        public string Avatar { get; set; }

        public string BackgroundAvatar { get; set; }

        public string NickName { get; set; }

        public string Slogan { get; set; }

        public string Pronouns { get; set; }

        public string Role { get; set; }

        public string About { get; set; }

        public string Company { get; set; }

        public int FieldId { get; set; }
    }
}
