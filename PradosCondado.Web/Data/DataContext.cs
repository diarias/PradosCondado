﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PradosCondado.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using PradosCondado.Web.Models;

namespace PradosCondado.Web.Data
{
    public class DataContext : IdentityDbContext<Userstbl>
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Aniostbl> Aniostbls { get; set; }
        public DbSet<Managerstbl> Managerstbls { get; set; }
        public DbSet<MarcasAutostbl> MarcasAutostbls { get; set; }
        public DbSet<Mesestbl> Mesestbls { get; set; }
        public DbSet<Negociostbl> Negociostbls{ get; set; }
        public DbSet<Pagostbl>  Pagostbls{ get; set; }
        public DbSet<PagosDeletetbl>  PagosDeletetbls{ get; set; }
        public DbSet<Productostbl>  Productostbls{ get; set; }
        public DbSet<Propietariostbl> Propietariostbls { get; set; }
        public DbSet<PuntosPagotbl> PuntosPagotbls { get; set; }
        public DbSet<TiposViviendatbl> TiposViviendatbls { get; set; }
        public DbSet<Valorestbl> Valorestbls { get; set; }
        public DbSet<Vehiculostbl> Vehiculostbls { get; set; }
        public DbSet<Egresostbl> Egresostbls { get; set; }
        public DbSet<Saldostbl> Saldostbls { get; set; }
        public DbSet<PradosCondado.Web.Data.Entities.TiposPagotbl> TiposPagotbl { get; set; }
        public DbSet<TiposPagotbl> TiposPagotbls { get; set; }
        public DbSet<TiposGastotbl> TiposGastotbls { get; set; }
        public DbSet<Noticiastbl> Noticiastbls { get; set; }
        public DbSet<TipoIdentificaciontbl> TipoIdentificaciontbls { get; set; }
        public DbSet<TipoPersonatbl> TipoPersonastbls { get; set; }
        public DbSet<EstadosFinancierostbl> EstadosFinancierostbls { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EstadosFinancierostbl>().HasKey(x => new { x.IdIngresos, x.IdEgresos});

            base.OnModelCreating(builder);

            builder.Entity<Vehiculostbl>()
                .HasIndex(v => v.Veh_Codigo)
                .IsUnique();
            builder.Entity<Aniostbl>()
                .HasIndex(a => a.Ani_Descripcion)
                .IsUnique();
            builder.Entity<Valorestbl>()
                .HasIndex(va => va.Val_Valor)
                .IsUnique();
            builder.Entity<PuntosPagotbl>()
                .HasIndex(p => p.Pun_Descripcion)
                .IsUnique();
            builder.Entity<TiposPagotbl>()
                .HasIndex(t => t.Tip_Descripcion)
                .IsUnique();
            builder.Entity<TiposGastotbl>()
                .HasIndex(t => t.Tip_Descripcion)
                .IsUnique();

            //builder.HasSequence<int>("", schema: "UrbPradosCondado")
            //.StartsAt(0)
            //.IncrementsBy(1);

            //builder.Entity<Pagostbl>()
            //    .Property(o => o.Borr_Id)
            //    .HasDefaultValueSql("NEXT VALUE FOR UrbPradosCondado.UrbPradosCondado");
        }



        

       




    }

}

