﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PradosCondado.Web.Data.Entities
{
    public class TipoPersonatbl
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Tipo de Persona")]
        public string TipP_Descripcion { get; set; }

        public ICollection<Userstbl> Propietarios { get; set; }
    }
}
