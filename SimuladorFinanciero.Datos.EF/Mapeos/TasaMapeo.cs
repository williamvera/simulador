

using ClassLibrary1;
using System.Data.Entity.ModelConfiguration;

namespace SimuladorFinanciero.Datos.EF.Mapeos
{
    public class TasaMapeo : EntityTypeConfiguration<Tasa>
    {
        //ctor
        public TasaMapeo()
        {
            ToTable("TASAS", "SF");
            HasKey(k => k.ID_Tasa);
            Property(p => p.ID_Tasa).HasColumnName("TASA_ID").IsRequired();
            Property(p => p.Esta_Activa).HasColumnName("ESTADO").IsRequired();
            Property(p => p.Fecha_Inicio).HasColumnName("INICIO").IsRequired();
            Property(p => p.Fecha_Termino).HasColumnName("TERMINO").IsRequired();
            Property(p => p.Monto_Maximo).HasColumnName("MONTO_MAXIMO").IsRequired();
            Property(p => p.Monto_Minimo).HasColumnName("MONTO_MINIMO").IsRequired();
            Property(p => p.Plazo_Maximo).HasColumnName("PLAZO_MAXIMO").IsRequired();
            Property(p => p.Plazo_Minimo).HasColumnName("PLAZO_MINIMO").IsRequired();
            Property(p => p.Valor_Tasa).HasColumnName("VALOR_TASA").IsRequired();
        }
    }
}
