using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DoAn.Models.Context;

namespace DoAn.Models
{
    public class TaskMessage : BaseEntity
    {
        [Required]
        public int TaskId { get; set; }

        [Required]
        public int UserCreated { get; set; }

        public string Description { get; set; }

        public int TypeId { get; set; }

        public bool IsMilestone { get; set; }
    }
}