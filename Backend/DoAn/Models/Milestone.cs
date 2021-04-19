using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DoAn.Models.Context;
namespace DoAn.Models
{
    public class Milestone : BaseEntity
    {
        [Required]
    public int ProjectId { get; set; }

    public int OptionProjectID { get; set; }

    [Required]
    public int UserCreated { get; set; }

    [Required]
    public int UserWork { get; set; }

    [Required]
    public int UserCheck { get; set; }

    public DateTime TaskStart { get; set; }

    public DateTime TaskEnd { get; set; }

    public string status { get; set; }

    public string Roles { get; set; }

    public int Process { get; set; }

    public string Evaluate { get; set; }

    public int TypeFieldId { get; set; }

    public int TypeLevelId { get; set; }

    public string Description { get; set; }

    public string Title { get; set; }

    public DateTime EditTime { get; set; }

    public int ParentId { get; set; }

    
    }
}
