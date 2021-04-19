using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DoAn.Models.Context;

namespace DoAn.Models
{
    public class Member : BaseEntity
    {
        public int ProjectId { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }

        public int UserCreated { get; set; }

        public string Note { get; set; }

        public string Roles { get; set; }

    }
}
