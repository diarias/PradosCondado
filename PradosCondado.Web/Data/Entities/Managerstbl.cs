﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PradosCondado.Web.Data.Entities
{
    public class Managerstbl
    {
        public int Id { get; set; }

        public Userstbl User { get; set; }
    }
}
