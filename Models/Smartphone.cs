namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; } = "Nokia";
        private string IMEI { get; set; } = "1234567890123456";
        private int Memoria { get; set; } = 16;
        public Smartphone(string numero)
        {
            Numero = numero;
    
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}