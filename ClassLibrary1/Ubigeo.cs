using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{

    /// <summary>
    /// Clase que representa la ubicacion de la persona
    /// </summary>
    public class Ubigeo
    {
        #region Propiedades
        /// <summary>
        /// Esta Clase ubigeo sirve para ver los datos de la ubicacion de la persona, y los metodos que se utilizaran
        /// </summary>
        public int ID_Ubigeo
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe el nombre del departamento
        /// </summary>
        public int Nombre_Departamento
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe el nombre del distrito
        /// </summary>
        public int Nombre_Distrito
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe el nombre de provincia
        /// </summary>
        public int Nombre_Provincia
        {
            get; set;
        }
        #endregion

        #region Constructor

        private Ubigeo() { }

        #endregion

        #region Metodo

        /// <summary>
        /// metodos de visualizacion de ubigeo
        /// </summary>
        public void Visualizar()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// metodos de modificacion de ubigeo
        /// </summary>
        public void Modificar()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// metodos de verificacion de ubigeo
        /// </summary>
        public void Verificar()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}