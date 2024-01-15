namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        private string modelo;
        private string imei;
        private string memoria;

        public Nokia(string numero) : base(numero)
        {
        }

        public Nokia(string numero, string Modelo, string Imei, string Memoria) : this(numero)
        {
            modelo = Modelo;
            imei = Imei;
            memoria = Memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo {0} no Nokia", nomeApp);
        }
    }
}