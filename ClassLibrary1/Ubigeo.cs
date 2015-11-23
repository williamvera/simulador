using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Ubigeo
    {
        /// <summary>
        /// Esta Clase ubigeo sirve para ver los datos de la uvicacion de la persona, y los metodos que se utilizaran
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

        /// <summary>
        /// metodos de la clase
        /// </summary>
        public void Visualizar()
        {
            throw new System.NotImplementedException();
        }

        public void Modificar()
        {
            throw new System.NotImplementedException();
        }

        public void Verificar()
        {
            throw new System.NotImplementedException();
        }
    }
}