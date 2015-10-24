using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class tasas : entidad_financiera
    {
        public int Fecha
        { get; set; }

        public int Monto
        {   get; set;}

        public int d_ahorro
        { get; set; }

        public int d_plazos
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int d_cts
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int d_plazos_pn
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int d_plazos_pj
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Listar()
        {
            throw new System.NotImplementedException();
        }
    }

    public class simulacion
    {
    }
}
