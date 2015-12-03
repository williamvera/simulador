using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class EntidadFinanciera
    {
        /// <summary>
        /// Campo que describe el id_entidad del clase
        /// </summary>
        public int IDEntidad { get; private set; }
        /// <summary>
        /// Campo que describe el nombre de la Entidad
        /// </summary>
        public int NombreEntidad { get; private set; }
        /// <summary>
        /// Esta Clase entidad financiera nos sirve para indicar los campos de la entidad financiera, y los metodos que se utilizaran
        /// </summary>
        public int Esta_Activa
        { get; set; }
        /// <summary>
        /// Campo que describe el tipo de la Entidad
        /// </summary>
        public int Tipo_Entidad { get; private set; }


        /// <summary>
        /// Campo que describe el tipo de entidad
        /// </summary>
        public TipoEntidad Tipo_Entidad1 { get; set; }

        /// <summary>
        /// metodos de la clase
        /// </summary>
        //public void Visualizar()
        //{
        //    throw new System.NotImplementedException();
        //}
        /// <summary>
        /// Metodo anular Entidad Financiera
        /// </summary>
        public void Anular()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// Metodo modificar Entidad Financiera
        /// </summary>
        public void Modificar()
        {
            throw new System.NotImplementedException();
        }
    }
}
