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

        public int idcliente
        {
            get;
            set;
        }

        public tasas_cliente tasas_cliente
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int idtasas_clinete
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void anular()
        {
            throw new System.NotImplementedException();
        }

        public void modificar()
        {
            throw new System.NotImplementedException();
        }

        public void visualizar()
        {
            throw new System.NotImplementedException();
        }
    }
}
