using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DoAn.Models.Context;

namespace DoAn.Models
{
    public class FieldTask : BaseEntity
    {
        [Required]
        public int ProjectId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string SortName { get; set; }

        [Required]
        public int UserCreated { get; set; }

        public DateTime StartFieldTime { get; set; }

        public DateTime EndFieldTime { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }


    }
}
