using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DoAn.Models.Context;
namespace DoAn.Models
{
    public class ReportProject : BaseEntity
    {
        public int ProjectId { get; set; }

        public int Process { get; set; }

        public int CompletedTasks { get; set; }

        public int IncompleteTasks { get; set; }

        public int OverdueTasks { get; set; }

        public int TotalTasks { get; set; }

        public string status { get; set; }

        public string Note { get; set; }
    }
}
