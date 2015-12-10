
using ClassLibrary1;
using System.Data.Entity.ModelConfiguration;

namespace SimuladorFinanciero.Datos.EF.Mapeos
{
    public class UsuarioMapeo : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapeo()
        {
            ToTable("USUARIOS", "SF");
            HasKey(k => k.ID_Usuario);
            Property(p => p.ID_Usuario).HasColumnName("USUARIO_ID").IsRequired();
            Property(p => p.Clave_Usuario).HasColumnName("USUARIO_CLAVE").IsRequired();
            Property(p => p.E_mail).HasColumnName("EMAIL").IsRequired();
            Property(p => p.Esta_Activo).HasColumnName("ESTADO").IsRequired();
            Property(p => p.Nombre_Usuario).HasColumnName("USUARIO_NOMBRE").IsRequired();
        }
       
    }
}
