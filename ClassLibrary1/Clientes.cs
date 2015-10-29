using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class cliente
    {
        /// <summary>
        /// Esta Clase cliente nos sirve para indicar los campos del cliente, y los metodos que se utilizaran
        /// </summary>
        public int nombre_rsocial
        { get; set; }

        public int dni_ruc
        { get; set; }

        public int telefono
        {   get; set;}

        public int email
        {
            get;
            set;
        }

        public int password
        {
            get;
            set;
        }
        /// <summary>
        /// metodos de la clase
        /// </summary>
        public tasas_cliente tasas_cliente
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
            get;
            set;
        }

        public void ver()
        {
            throw new System.NotImplementedException();
        }

        public void simular()
        {
            throw new System.NotImplementedException();
        }

        public void monto()
        {
            throw new System.NotImplementedException();
        }

        public void crear()
        {
            throw new System.NotImplementedException();
        }

        public void anular()
        {
            throw new System.NotImplementedException();
        }
    }
}
