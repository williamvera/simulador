using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class usuario : tasas_cliente
    {
        public int idusuario
        {   get; set;}

        public int nombre
        { get; set; }

        public int telefono
        { get; set; }

        public int dni
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int email
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

        public void modificar()
        {
            throw new System.NotImplementedException();
        }
    }
}
