using DoAn.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class Section : BaseEntity
    {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public int Creator { get; set; }

        public string Description { get; set; }

    }
}
