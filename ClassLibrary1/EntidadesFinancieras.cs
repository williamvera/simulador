using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class entidad_financiera
    {
        public int descripcion
        {   get; set;}

        public int direccion
        {   get; set;}

        public int nombre_entidad
        {   get; set;}

        public int tipo_entidad
        { get; set; }

        public int tipo_tasas
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int clinete
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
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

        public int identidad_financiera
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int idtas_cliente
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Agregar()
        {
            throw new System.NotImplementedException();
        }

        public void Listar()
        {
            throw new System.NotImplementedException();
        }

        public void Modificar()
        {
            throw new System.NotImplementedException();
        }
    }
}
