using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DoAn.Models.Context;

namespace DoAn.Models
{
    public class Field : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }
    }
}
