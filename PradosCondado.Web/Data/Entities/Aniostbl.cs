﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PradosCondado.Web.Data.Entities
{
    public class Aniostbl
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "AÑO")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El registro es obligatorio")]
        [StringLength(4, MinimumLength =4, ErrorMessage = "El año debe tener solo 4 numeros")]
        public string Ani_Descripcion { get; set; }

        [Display(Name = "ESTADO")]
        public char Ani_Estado { get; set; }

        public ICollection<Pagostbl> Pagos { get; set; }
        public ICollection<PagosDeletetbl> PagosDel { get; set; }

        public ICollection<Egresostbl> Egresos { get; set; }
    }
}
