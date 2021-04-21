using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DoAn.Models.Context;

namespace DoAn.Models
{
    public class Option : BaseEntity
    {
        public string Name { get; set; }

        [Required]
        public string Key { get; set; }

        public string Value { get; set; }

        public string Note { get; set; }
    }
}
