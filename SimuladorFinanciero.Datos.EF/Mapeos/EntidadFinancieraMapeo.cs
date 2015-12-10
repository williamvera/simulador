
using ClassLibrary1;
using System.Data.Entity.ModelConfiguration;

namespace SimuladorFinanciero.Datos.EF.Mapeos
{
    public class EntidadFinancieraMapeo : EntityTypeConfiguration<EntidadFinanciera>
    {
        public EntidadFinancieraMapeo()
        {
            ToTable("ENTIDAD_FINANCIERA", "SF");
            HasKey(k => k.ID_Entidad);
            Property(p => p.ID_Entidad).HasColumnName("ENTIDAD_ID").IsRequired();
            Property(p => p.EstaActiva).HasColumnName("ESTADO").IsRequired();
            Property(p=> p.NombreEntidad).HasColumnName("NOMBRE").IsRequired();
            Property(p => p.ID_TipoEntidad).HasColumnName("TIPO_ID").IsRequired();

            HasRequired(m => m.Tipo).WithMany().HasForeignKey(f => f.ID_TipoEntidad);

        }
    }
}
