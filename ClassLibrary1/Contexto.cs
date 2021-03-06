﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    /// <summary>
    /// Clase que representa el contexto
    /// </summary>
    public class Contexto : DbContext
    {
        /// <summary>
        /// Esta Clase contexto nos sirve para indicar los parametros de conexion estaleciendo los Id principales de cada clase 
        /// </summary>
        public Contexto()
            : base("CNX")
        {
        }
        /// <summary>
        /// Fijamos el Get y Set para Usuario
        /// </summary>
        public DbSet<Usuario> Usuario { get; set; }
        /// <summary>
        /// Fijamos el Get y Set para Tasa
        /// </summary>
        public DbSet<Tasa> Tasa { get; set; }
        /// <summary>
        /// Fijamos el Get Set para Entidad Financiera
        /// </summary>
        public DbSet<EntidadFinanciera> Entidad_Financiera { get; set; }
        /// <summary>
        /// Fijamos el Get Set para Tipo de Entidad
        /// </summary>
        public DbSet<TipoEntidad> Tipo_Entidad { get; set; }
        /// <summary>
        /// Fijamos el Get Set para la Oficina
        /// </summary>
        public DbSet<Oficina> Oficina { get; set; }
        /// <summary>
        /// Fijamos el Get Set para Ubigeo
        /// </summary>
        public DbSet<Ubigeo> Ubigeo { get; set; }
        /// <summary>
        /// Establecemos las claves primarias de cada una delas entidades
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasKey(k => k.ID_Usuario);
            modelBuilder.Entity<EntidadFinanciera>().HasKey(k => k.ID_Entidad);
            modelBuilder.Entity<TipoEntidad>().HasKey(k => k.ID_TipoEntidad);
            modelBuilder.Entity<Tasa>().HasKey(k => k.ID_Tasa);
            modelBuilder.Entity<Oficina>().HasKey(k => k.ID_Oficina);
            modelBuilder.Entity<Ubigeo>().HasKey(k => k.ID_Ubigeo);

        }
    }
}
