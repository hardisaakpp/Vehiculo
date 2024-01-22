using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo.Logic
{
    public class Automovil : Vehiculo
    {
        // Atributo adicional con validacion de propiedad
        private int Puertas;

        public int puertas
        {
            get { return puertas; }
            set
            {
                // Validar que el número de puertas sea mayor que 0
                if (value > 0)
                {
                    puertas = value;
                }
                else
                {
                    Console.WriteLine("El número de puertas debe ser mayor que 0");
                }
            }
        }

        // Constructor de la clase derivada
        public Automovil(string marca, string modelo, int año, int puertas)
            : base(marca, modelo, año)
        {
            Puertas = puertas;
        }

        // Método para obtener la información específica del automóvil que muestra la información del vehículo y la cantidad de puertas.
        public new string GetInformation()
        {
            return $"{base.GetInformation()}, Puertas: {Puertas}";
        }
    }
}
