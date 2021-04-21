using DoAn.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class MyTask : BaseEntity
    {
        public int Owver { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
