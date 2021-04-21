using DoAn.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class TaskStatus : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
