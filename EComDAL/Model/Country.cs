﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Country : AuditFields
    {
        [Required]
        [StringLength(50, ErrorMessage = "Country Name cannot exceed 50 characters")]
        public string? Country_Name { get; set; }
    }
}
