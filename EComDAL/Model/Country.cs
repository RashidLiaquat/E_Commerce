﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Country : AuditFields
    {
        public string? Country_Name { get; set; }
        public Province? Province_Id { get; set; }
    }
}
