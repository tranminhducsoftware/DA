using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DoAn.Models.Context;

namespace DoAn.Models
{
    public class Notification : BaseEntity
    {
        [Required]
        public int UserSend { get; set; }

        [Required]
        public int UserTo { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int TypeId { get; set; }

        public int TaskId { get; set; }

    }
}
