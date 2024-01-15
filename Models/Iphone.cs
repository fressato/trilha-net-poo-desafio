namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        private string imei;
        private string memoria;

        public Iphone(string numero, string Modelo) : base(numero)
        {
        }

        public Iphone(string numero, string Modelo, string Imei, string Memoria) : this(numero, Modelo)
        {
            imei = Imei;
            memoria = Memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo {0} no Iphone", nomeApp);
        }
    }
}