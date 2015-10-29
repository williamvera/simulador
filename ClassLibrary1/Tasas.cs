using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class tasas
    {
        /// <summary>
        /// Esta Clase tasas nos sirve para indicar los campos de las tasas, y los metodos que se utilizaran
        /// </summary>
        public int Fecha
        { get; set; }

        public int Monto
        {   get; set;}

        public int d_ahorro
        { get; set; }

        public int d_plazos
        {
            get;
            set;
        }

        public int d_cts
        {
            get;
            set;
        }

        public int d_plazos_pn
        {
            get;
            set;
        }

        public int d_plazos_pj
        {
            get;
            set;
        }

        public int idtasas
        {
            get;
            set;
        }

        public entidad_financiera entidad_financiera
        {
            get;
            set;
        }

        public int ientidad_financiera
        {
            get;
            set;
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
