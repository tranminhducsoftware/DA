using DoAn.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class TaskCollaborator : BaseEntity
    {
        public int TaskId { get; set; }

        public int Collaborator { get; set; }

        public string Note { get; set; }
    }
}
