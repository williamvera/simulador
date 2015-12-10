

using ClassLibrary1;
using System.Data.Entity.ModelConfiguration;

namespace SimuladorFinanciero.Datos.EF.Mapeos
{
    public class UbigeoMapeo : EntityTypeConfiguration<Ubigeo>
    {
        public UbigeoMapeo()
        {
            ToTable("UBIGEOS", "SF");
            HasKey(k => k.ID_Ubigeo);
            Property(p => p.Nombre_Departamento).HasColumnName("NOMBRE_DEPARTAMENTO").IsRequired();
            Property(p => p.Nombre_Distrito).HasColumnName("NOMBRE DISTRITO").IsRequired();
            Property(p => p.Nombre_Provincia).HasColumnName("NOMBRE PROVINCIA").IsRequired();
           
        }
    }
}
