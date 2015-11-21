using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Contexto : DbContext
    {
        /// <summary>
        /// Esta Clase contexto nos sirve para indicar los parametros de conexion estaleciendo los Id principales de cada clase 
        /// </summary>
        public Contexto()
            : base("CNX")
        {
        }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Tasa> tasa { get; set; }
        public DbSet<Entidad_Financiera> Entidad_Financiera { get; set; }
        public DbSet<Tipo_Entidad> Tipo_Entidad { get; set; }
        public DbSet<Oficina> Oficina { get; set; }
        public DbSet<Ubigeo> Ubigeo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasKey(k => k.ID_Usuario);
            modelBuilder.Entity<Entidad_Financiera>().HasKey(k => k.ID_Entidad);
            modelBuilder.Entity<Tipo_Entidad>().HasKey(k => k.ID_Tipo);
            modelBuilder.Entity<Tasa>().HasKey(k => k.ID_Tasa);
            modelBuilder.Entity<Oficina>().HasKey(k => k.ID_Oficina);
            modelBuilder.Entity<Ubigeo>().HasKey(k => k.ID_Ubigeo);

        }
    }
}
