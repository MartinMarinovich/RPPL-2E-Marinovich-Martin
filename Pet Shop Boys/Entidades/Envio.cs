using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

namespace Entidades
{
    public class Envio
    {
        float precio;
        Evehiculo vehiculo;
        int recorrido;
        public Envio(float precio, Evehiculo vehiculo,int recorrido)
        {
            this.precio = precio;
            this.vehiculo = vehiculo;

        }


        public float Precio
        {
            set
            {
                if (value > 0)
                {
                    this.precio = value;
                }
            }

            get
            {
                return this.precio;
            }
        }



        public Evehiculo Transporte
        {
            set
            {
                this.vehiculo = value;
            }

            get
            {
                return this.vehiculo;
            }
        }


        public int Recorrido
        {
            set
            {
                if (value > 0)
                {
                    this.recorrido = value;
                }
            }

            get
            {
                return this.recorrido;
            }
        }
    }
}
