
namespace Vehiculo.Logic
{
    internal class Camioneta
    {
        private string v1;
        private string v2;
        private int v3;
        private double v4;

        public Camioneta(string v1, string v2, int v3, double v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public string Color { get; internal set; }
        public double Precio { get; internal set; }

        internal bool GetInformation()
        {
            throw new NotImplementedException();
        }

        internal void RunAction()
        {
            throw new NotImplementedException();
        }
    }
}