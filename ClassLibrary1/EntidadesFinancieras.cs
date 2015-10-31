using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class entidad_financiera
    {
        /// <summary>
        /// Esta Clase entidad financiera nos sirve para indicar los campos de la entidad financiera, y los metodos que se utilizaran
        /// </summary>
        public int descripcion
        { get; set; }

        public int nombre_entidad
        {   get; set;}

        public int tipo_entidad
        { get; set; }

        public int identidad_financiera
        {
            get;
            set;
        }

        public int idtasas_cliente
        {
            get;
            set;
        }

        public tasas_cliente tasas_cliente1
        {
            get;
            set;
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
