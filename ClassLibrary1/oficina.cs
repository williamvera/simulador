using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Oficina
    {
        /// <summary>
        /// Esta Clase Oficina sirve para ver el nombre de la oficina y la localizacion, y los metodos que se utilizaran
        /// </summary>
        public int Direccion_Oficina
        {
            get; set;
        }

        public int ID_Oficina
        {
            get; set;
        }

        public int Esta_Activa
        {
            get; set;
        }

        public int Localizacion
        {
            get; set;
        }

        public int Nombre_Oficina
        {
            get; set;
        }

        public int ID_Entidad
        {
            get; set;
        }

        public int ID_Ubigeo
        {
            get; set;
        }
        public Ubigeo Ubigeo
        {
            get; set;
        }
        public Entidad_Financiera Entidad_Financiera
        {
            get; set;
        }

        /// <summary>
        /// metodos de la clase
        /// </summary>
        public void visualizar()
        {
            throw new System.NotImplementedException();
        }
    }
}
