using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DoAn.Models.Context
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
