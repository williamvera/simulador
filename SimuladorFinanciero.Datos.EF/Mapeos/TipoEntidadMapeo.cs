

using ClassLibrary1;
using System.Data.Entity.ModelConfiguration;

namespace SimuladorFinanciero.Datos.EF.Mapeos
{
    public class TipoEntidadMapeo : EntityTypeConfiguration<TipoEntidad>
    {
        //ctor
        public TipoEntidadMapeo()
        {
            ToTable("TIPO_ENTIDAD", "SF");
            HasKey(k => k.ID_TipoEntidad);
            Property(p => p.ID_TipoEntidad).HasColumnName("TIPO_ENTIDAD_ID").IsRequired();
            Property(p => p.EstaActivo).HasColumnName("ESTADO").IsRequired();
            Property(p => p.DescripcionTipoEntidad).HasColumnName("DESCRIPCION").IsRequired();
                        
        }
    }
}
