
namespace Vehiculo.Logic
{
    internal class Automovil
    {
        private string v1;
        private string v2;
        private int v3;
        private int v4;

        public Automovil(string v1, string v2, int v3, int v4)
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