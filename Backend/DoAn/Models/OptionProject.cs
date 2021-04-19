using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Models.Context;
using System.ComponentModel.DataAnnotations;

namespace DoAn.Models
{
    public class OptionProject : BaseEntity
    {
        [Required]
        public int ProjectId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Key { get; set; }

        [Required]
        public int Type { get; set; }

        public string Value { get; set; }

    }
}
