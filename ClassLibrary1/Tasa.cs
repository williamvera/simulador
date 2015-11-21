using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Tasa
    {
        /// <summary>
        /// Esta Clase Tasa nos sirme para verficar los montos y los plazos de maximo a minimo y el valor de la taza
        /// , y los metodos que se utilizaran
        /// </summary>
        public int Esta_Activa
        {
            get; set;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Fecha_Inicio
        {
            get; set;
        }

        public int Fecha_Termino
        {
            get; set;
        }


        public int Monto_Maximo
        {
            get; set;
        }

        public int Monto_Minimo
        {
            get; set;
        }

        public int Plazo_Maximo
        {
            get; set;
        }

        public int Plazo_Minimo
        {
            get; set;
        }

        public int Valor_Tasa
        {
            get; set;
        }

        public int ID_Tasa
        {
                get; set;
            }

        public Oficina Oficina

        {
            get; set;
        }

        /// <summary>
        /// metodos de la clase
        /// </summary>
        public void VIsualizar()
        {
            throw new System.NotImplementedException();
        }

        public void Modificar()
        {
            throw new System.NotImplementedException();
        }
    }
}