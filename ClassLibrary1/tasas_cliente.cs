using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class tasas_cliente
    {
        /// <summary>
        /// Esta Clase tasas_cliente nos sirve para indicar los campos del cliente con respecto las tasas, y los metodos que se utilizaran
        /// </summary>
        public int identidad_financiera
        {
            get;
            set;
        }

        public int idcliente
        {
            get;
            set;
        }

        public int idtasas_cliente
        {
            get;set;
        }

        public cliente cliente
        {
            get;
            set;
        }
        /// <summary>
        /// metodos de la clase
        /// </summary>
        public void listar()
        {
            throw new System.NotImplementedException();
        }

        public void modificar()
        {
            throw new System.NotImplementedException();
        }
    }
}
