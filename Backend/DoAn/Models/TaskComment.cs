using DoAn.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class TaskComment : BaseEntity
    {
        public int TaskId { get; set; }

        public int Creator { get; set; }

        public string Content { get; set; }
    }
}
