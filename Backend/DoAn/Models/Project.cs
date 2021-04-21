using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DoAn.Models.Context;


namespace DoAn.Models
{
    public class Project : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public int Owner { get; set; }

        public int DefaultViewId { get; set; }

        public int PrivacyId { get; set; }

        public int TeamId { get; set; }

        public int IconId { get; set; }

        public int ColorId { get; set; }

        public string Description { get; set; }

        public DateTime EndTime { get; set; }

        public int Status { get; set; }


    }
}
