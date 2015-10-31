using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// Esta Clase login nos sirve para indicar los campos del login, y los metodos que se utilizaran
    /// </summary>
    public class login
    {
        /// <summary>
        /// propiedad idlogin es le identificador del login
        /// </summary>
        public int idlogin { get; set; }
        public int password { get; set; }

        public int idcliente { get; set;}
        
        public int cliente { get; set;}

        public cliente cliente1
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
        /// metodos de la clase
        /// </summary>
        public void crear_cuenta()
        {
            throw new System.NotImplementedException();
        }

        public void acceso()
        {
            throw new System.NotImplementedException();
        }

        public void olvido_pass()
        {
            throw new System.NotImplementedException();
        }
    }
}
