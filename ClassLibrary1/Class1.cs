using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class usuario
    {
        public int idusuario
        {
            get;
            set;

        }

        public int nombre
        {
            get;

            set;

        }

        public int apellido
        {
            get;
            
            set;
            
        }

        public int telefono
        {
            get;

            set;
            
        }
        public login login
        {
            get;

            set;

        }

        public login login1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void listar()
        {
            throw new System.NotImplementedException();
        }
    }
}
