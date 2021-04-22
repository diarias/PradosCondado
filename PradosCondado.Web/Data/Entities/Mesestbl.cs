﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PradosCondado.Web.Data.Entities
{
    public class Mesestbl
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "MES")]
        public string Mes_Descripcion { get; set; }

        public ICollection<Pagostbl> Pagos { get; set; }
        public ICollection<PagosDeletetbl> PagosDel { get; set; }
        public ICollection<Egresostbl> Egresos { get; set; }
    }
}
