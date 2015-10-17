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
        public Contexto()
            : base("CNX")
        {
        }
        public DbSet<usuario> usuario { get; set; }
        public DbSet<login> login { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<usuario>().HasKey(k => k.idusuario);
            modelBuilder.Entity<login>().HasKey(k => k.idlogin);
        }
    }
}
