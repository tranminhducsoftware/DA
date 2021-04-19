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
        public int FieldId { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        public string SortName { get; set; }

        public int UserCreated { get; set; }

        public DateTime EndDateTime { get; set; }

        public int PrivacyId { get; set; }

        public int DefaultViewId { get; set; }

        public int OwnProject { get; set; }

    }
}
