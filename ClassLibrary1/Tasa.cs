using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{

    /// <summary>
    /// Clase que representa la cativacion y la fecha de la tasa
    /// </summary>
    public class Tasa
    {
        #region Propiedades
        /// <summary>
        /// Esta Clase Tasa nos sirme para verficar los montos y los plazos de maximo a minimo y el valor de la taza
        /// , y los metodos que se utilizaran
        /// </summary>
        public int Esta_Activa
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe la fecha de inicio de la tasa
        /// </summary>
        public int Fecha_Inicio
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe la fecha de termino de la tasa
        /// </summary>
        public int Fecha_Termino
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe el monto maximo de la tasa
        /// </summary>
        public int Monto_Maximo
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe el monto minimo de la tasa
        /// </summary>
        public int Monto_Minimo
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe el plazo maximo de la tasa
        /// </summary>
        public int Plazo_Maximo
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe el plazo minimo de la tasa
        /// </summary>
        public int Plazo_Minimo
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe el valor de la tasa 
        /// </summary>
        public int Valor_Tasa
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe el id_tasa 
        /// </summary>
        public int ID_Tasa
        {
                get; set;
            }

        /// <summary>
        /// campo que describe la oficina
        /// </summary>
        public Oficina Oficina

        {
            get; set;
        }
        #endregion

        #region Constructor

        private Tasa() { }

        #endregion

        #region Metodo

        /// <summary>
        /// metodos de visualizacion de la tasa
        /// </summary>
        public void VIsualizar()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// metodos de modificacion de la tasa
        /// </summary>
        public void Modificar()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// metodos de eliminacion de la oficina
        /// </summary>
        public void Eliminar()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}