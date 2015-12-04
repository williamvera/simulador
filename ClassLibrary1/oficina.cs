using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// Clase que representa la localizacion de la oficina
    /// </summary>
    public class Oficina
    {
        /// <summary>
        /// Esta Clase Oficina sirve para ver el nombre de la oficina y la localizacion, y los metodos que se utilizaran
        /// </summary>
        public int Direccion_Oficina
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe el id_oficina
        /// </summary>
        public int ID_Oficina
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe el esta_activa o no 
        /// </summary>
        public int Esta_Activa
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe la localizacion
        /// </summary>
        public int Localizacion
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe nombre de la oficina
        /// </summary>
        public int Nombre_Oficina
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe id_entidad
        /// </summary>
        public int ID_Entidad
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe id_ubigeo
        /// </summary>
        public int ID_Ubigeo
        {
            get; set;
        }
        /// <summary>
        /// Campo que describe el ubigeo la localizacion
        /// </summary>
        public Ubigeo Ubigeo
        {
            get; set;
        }
        /// <summary>
        /// Campo que describe la entidad de financiera
        /// </summary>
        public EntidadFinanciera Entidad_Financiera
        {
            get; set;
        }

        public EntidadFinanciera EntidadFinanciera
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// metodos de visualizacion de oficina
        /// </summary>
        public void Visualizar()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// metodos de agregacion de oficina
        /// </summary>
        public void Agregar()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// metodos de eliminacion de oficina
        /// </summary>
        public void Eliminar()
        {
            throw new System.NotImplementedException();
        }
    }
}
