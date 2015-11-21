using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Entidad_Financiera
    {
        /// <summary>
        /// Esta Clase entidad financiera nos sirve para indicar los campos de la entidad financiera, y los metodos que se utilizaran
        /// </summary>
        public int Esta_Activa
        { get; set; }
        /// <summary>
        /// Campo que describe el nombre de la Entidad
        /// </summary>
        public int Nombre_Entidad
        {   get; set;}

        public int Tipo_Entidad
        { get; set; }

        public int ID_Entidad
        {
            get;set;
        }

        public Tipo_Entidad Tipo_Entidad1
        {
            get; set;
        }

        /// <summary>
        /// metodos de la clase
        /// </summary>
        public void Agregar()
        {
            throw new System.NotImplementedException();
        }

        public void anular()
        {
            throw new System.NotImplementedException();
        }
    }
}
