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

        /// <summary>
        /// Constructor del objeto envio instanci los atributos float precio, enumerador vehiculo y cantidad de recorrido
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="vehiculo"></param>
        /// <param name="recorrido"></param>
        public Envio(float precio, Evehiculo vehiculo,int recorrido)
        {
            Precio = precio;
            Transporte = vehiculo;
            Recorrido = recorrido;

        }

        /// <summary>
        /// Propiedad precio del envio lo setea y devuelve el valor
        /// </summary>
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


        /// <summary>
        /// Propiedad enumerador del transporte, setea el tipo y devuelve ya esta prestablecido
        /// </summary>
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

        /// <summary>
        /// Propiedad recorrido que hace el vehiculo se determina por la distancia del cliente, setea y devuelve el valor
        /// </summary>
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

        /// <summary>
        /// Conversor explicito a string de los tamos precio y vehiculo del objeto envio
        /// </summary>
        /// <param name="envio"></param>
        public static explicit operator string(Envio envio)
        {
            string formato = string.Empty;
            formato = string.Format("Transporte: {0,-12}Precio:{1,6}", envio.vehiculo,envio.precio);
            return formato;
        }
    }
}
