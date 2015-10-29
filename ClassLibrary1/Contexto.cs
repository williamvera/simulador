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
        public DbSet<cliente> cliente { get; set; }
        public DbSet<login> login { get; set; }
        public DbSet<tasas_cliente> tasas_cliente { get; set; }
        public DbSet<entidad_financiera> entidad_financiera { get; set; }
        public DbSet<tasas> tasas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<cliente>().HasKey(k => k.idcliente);
            modelBuilder.Entity<login>().HasKey(k => k.idlogin);
            modelBuilder.Entity<tasas_cliente>().HasKey(k => k.idtasas_cliente);
            modelBuilder.Entity<entidad_financiera>().HasKey(k => k.identidad_financiera);
            modelBuilder.Entity<tasas>().HasKey(k => k.idtasas);

        }
    }
}
