using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Usuario
    {
        /// <summary>
        /// Esta Clase usuario sirve para tener ams detalles de la persona q ingresara al sistema
        /// </summary>
        public int ID_Usuario
        {
            get;
            set;
        }

        /// <summary>
        /// Campo que describe la clave del ususario
        /// </summary>
        public int Clave_Usuario
        {
            get;
            set;
        }
        /// <summary>
        /// Campo que deve darse el correo electronico
        /// </summary>
        public int E_mail
        
        {
            get; set;
        }

        /// <summary>
        /// Campo que describe el estado activo de la persona
        /// </summary>
        public int Esta_Activo
          {
            get; set;
        }

         /// <summary>
        /// Campo que describe el nombre de usuario
        /// </summary>
        public int Nombre_Usuario
         {
            get; set;

         }
    }
}
 