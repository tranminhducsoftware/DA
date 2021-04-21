using DoAn.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class Favorite : BaseEntity
    {
        public int ProjectId { get; set; }

        public int UserId { get; set; }

        public string Reason { get; set; }
    }
}
