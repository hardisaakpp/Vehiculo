using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo.Logic
{
    //Crea una clase llamada "Vehiculo"
    public class Vehiculo
    {
        #region Atributos
        private string marca;
        private string modelo;
        private int año;
        #endregion

        #region Propiedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        #endregion

        public override string ToString()
        {
            return base.ToString();
        }

        #region Constructor
        public Vehiculo(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        // Método para obtener la información del vehículo
        public string GetInformation()
        {
            return $"Vehiculo: {Marca} {Modelo}, Año {Año}";
        }

        // Método para realizar una acción genérica del vehículo
        public void RunAction()
        {
            Console.WriteLine("Encendiendo el vehículo...");
        }
        #endregion
    }
}
