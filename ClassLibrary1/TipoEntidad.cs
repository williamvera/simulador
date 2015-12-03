using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// Clase que representa los tipos de Entidades Financieras
    /// </summary>
    public class TipoEntidad
    {
        #region Propiedades

        
        /// <summary>
        /// Esta Clase Tipo entidad nos sirve para la verificacion de descripcion de tipo, y los metodos que se utilizaran
        /// </summary>
        public byte IDTipoEntidad { get; private set; }
        /// <summary>
        /// Campo que describe la descripcion de tipo
        /// </summary>
        public string DescripcionTipoEntidad { get; private set; }
        /// <summary>
        /// Indica si el objeto se cuentra activo o no
        /// </summary>
        public string EstaActivo { get; private set; }

        #endregion

        #region Constructor

        private TipoEntidad() { }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo para crear una instancia nueva de la clase TipoEntidad
        /// </summary>
        /// <param name="as_descripcion_tipo">Descripcion del Tipo de Entidad</param>
        /// <returns>Instancia nueva de la clase TipoEntidad</returns>
        public static TipoEntidad Crear( string as_descripcion_tipo )
        {
            return new TipoEntidad()
            {
                DescripcionTipoEntidad = as_descripcion_tipo,
                EstaActivo = "S"
            };
        }
        /// <summary>
        /// Metodo para Anular una instancia de la clase TipoEntidad
        /// </summary>
        public void Anular()
        {
            EstaActivo = "N";
        }

        #endregion
    }
}
