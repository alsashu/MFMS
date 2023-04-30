﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFMS.Domain
{
    [Table("working_hours")]
    public class WorkingHour
    {
        [Key, Required]
        public int id { get; set; }
        public string name { get; set; } = String.Empty;
        public bool status { get; set; }
    }
}
