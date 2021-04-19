﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DoAn.Models.Context;

namespace DoAn.Models
{
    public class Role :BaseEntity
    {
        public string Name { get; set; }

        public string SortName { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }

        public int UserCreated { get; set; }
    }
}