﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// Clase que representa los diferentes tipos de entidades financiera
    /// </summary>
    public class EntidadFinanciera
    {
        #region Propiedades

        /// <summary>
        /// Campo que describe el id_entidad del clase
        /// </summary>
        public int ID_Entidad { get; private set; }
        /// <summary>
        /// Campo que describe el nombre de la Entidad
        /// </summary>
        public string NombreEntidad { get; private set; }
        /// <summary>
        /// Esta Clase entidad financiera nos sirve para indicar los campos de la entidad financiera, y los metodos que se utilizaran
        /// </summary>
        public string EstaActiva { get; private set; }
        /// <summary>
        /// Campo que describe el tipo de la Entidad
        /// </summary>
        public byte ID_TipoEntidad { get; private set; }
        /// <summary>
        /// Campo que describe el tipo de entidad
        /// </summary>
        public virtual TipoEntidad Tipo { get; private set; }

        #endregion

        #region Constructor

        private EntidadFinanciera()
        {
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Entidad financiera relacionando con tipo entidad
        /// </summary>
        /// <param name="as_nom_entidad"></param>
        /// <param name="aby_id_tipo"></param>
        /// <returns></returns>

        public static EntidadFinanciera Crear(string as_nom_entidad, byte aby_id_tipo)
        {
            return new EntidadFinanciera()
            {
                NombreEntidad = as_nom_entidad,
                ID_TipoEntidad = aby_id_tipo,
                EstaActiva = "S"
            };
        }

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
        #endregion
    }
}
