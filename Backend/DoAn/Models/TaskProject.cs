using DoAn.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class TaskProject :BaseEntity
    {
        public int ProjectId { get; set; }

        public int SectionId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Creator { get; set; }

        public int Assignee { get; set; }

        public int MyTaskId { get; set; }

        public DateTime DueDate { get; set; }

        public int PriorityId { get; set; }

        public int ParentId { get; set; }

        public int StatusId { get; set; }

        public bool IsMilestone { get; set; }

    }
}
