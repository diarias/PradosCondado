﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using PradosCondado.Web.Data.Entities;

namespace PradosCondado.Web.Data.Entities
{
    public class Propietariostbl
    {
        public int Id { get; set; }

        public Userstbl User { get; set; }

        public ICollection<Vehiculostbl> Vehiculos { get; set; }

        public ICollection<Pagostbl> Pagos { get; set; }

        public ICollection<Negociostbl> Negocio { get; set; }


      


    }
}
