

using ClassLibrary1;
using System.Data.Entity.ModelConfiguration;

namespace SimuladorFinanciero.Datos.EF.Mapeos
{
    public class OficinaMapeo : EntityTypeConfiguration<Oficina>
    {
        public OficinaMapeo()
        {
            ToTable("OFICINAS", "SF");
            HasKey(k => k.ID_Oficina);
            Property(p => p.ID_Oficina).HasColumnName("OFICINA_ID").IsRequired();
            Property(p => p.Direccion_Oficina).HasColumnName("DIRECCION").IsRequired();
            Property(p => p.Esta_Activa).HasColumnName("ESTADO").IsRequired();
            Property(p => p.Localizacion).HasColumnName("LOCALIZACION").IsRequired();
            Property(p => p.Nombre_Oficina).HasColumnName("NOMBRE_OFICINA").IsRequired();
            Property(p => p.ID_Entidad).HasColumnName("ENTIDAD_FINANCIERA_ID").IsRequired();
            Property(p => p.ID_Ubigeo).HasColumnName("UBIGEO_ID").IsRequired();

            HasRequired(m => m.EntidadFinanciera).WithMany().HasForeignKey(f => f.ID_Entidad);
            HasRequired(m => m.Ubigeo).WithMany().HasForeignKey(f => f.ID_Ubigeo);
        }
    }
}
