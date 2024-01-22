using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo.Logic
{
    public class Camioneta : Vehiculo
    {
        // Atributo adicional con validación de propiedad
        private double capacidad_de_carga;

        public double CapacidadCarga
        {
            get { return capacidad_de_carga; }
            set
            {
                // Validar que la capacidad de carga sea mayor o igual a 0
                if (value >= 0)
                {
                    capacidad_de_carga = value;
                }
                else
                {
                    Console.WriteLine("La capacidad de carga debe ser igual o mayor que 0");
                }
            }
        }

        // Constructor de la clase derivada
        public Camioneta(string marca, string modelo, int año, double capacidadCarga)
            : base(marca, modelo, año)
        {
            CapacidadCarga = capacidadCarga;
        }

        // Método para obtener la información específica de la camioneta
        public new string GetInformation()
        {
            return $"{base.GetInformation()}, Capacidad de Carga: {CapacidadCarga} kg";
        }
    }
}