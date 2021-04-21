using DoAn.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class ProjectResource :BaseEntity
    {
        public int ProjectId { get; set; }

        public string Type { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
