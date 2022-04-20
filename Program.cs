using System;

namespace Aula02
{
    public class Cadeira
    {
        public int QuantidadeDePernas { get; set; }
        public int AlturaDasPernas { get; set; }
        public int AlturaDoAssento { get; set; }
        public int AlturaDoEncosto { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cadeira cadeiraLeroyMerlin = new Cadeira();
            cadeiraLeroyMerlin.AlturaDoAssento = 5;
            cadeiraLeroyMerlin.AlturaDoEncosto = 25;
            cadeiraLeroyMerlin.AlturaDasPernas = 30;

            Cadeira cadeiraCasasBahia = new Cadeira();
            cadeiraCasasBahia.AlturaDoAssento = 10;
            cadeiraCasasBahia.AlturaDoEncosto = 50;
            cadeiraCasasBahia.AlturaDasPernas = 60;

            Cadeira cadeiraMagazineLuiza = new Cadeira();
            cadeiraMagazineLuiza.AlturaDoAssento = 15;
            cadeiraMagazineLuiza.AlturaDoEncosto = 20;
            cadeiraMagazineLuiza.AlturaDasPernas = 45;

            //CONCATENAÇÃO DE STRING
            Console.WriteLine("A altura da cadeira Leroy Merlin é: " + CalcularAlturaDaCadeira(cadeiraLeroyMerlin) + " centímetros");
            Thread.Sleep(1000);
            Console.WriteLine("A altura da cadeira Casas Bahia é: " + CalcularAlturaDaCadeira(cadeiraCasasBahia) + " centímetros");
            Thread.Sleep(1000);
            Console.WriteLine("A altura da cadeira Magazine Luiza é: " + CalcularAlturaDaCadeira(cadeiraMagazineLuiza) + " centímetros");
            Thread.Sleep(1000);

            //INTERPOLAÇÃO DE STRING
            Console.WriteLine($"A altura da cadeira Leroy Merlin é: {CalcularAlturaDaCadeira(cadeiraLeroyMerlin)} centímetros");
            Thread.Sleep(1000);
            Console.WriteLine($"A altura das pernas da cadeira Leroy Merlin é: {cadeiraLeroyMerlin.AlturaDasPernas} centímetros");
            Thread.Sleep(1000);
            Console.WriteLine($"A altura do encosto da cadeira Leroy Merlin é: {cadeiraLeroyMerlin.AlturaDoEncosto} centímetros");

        }

        public static int CalcularAlturaDaCadeira(Cadeira cadeira)
        {
            int alturaDaCadeira = cadeira.AlturaDoEncosto + cadeira.AlturaDoAssento + cadeira.AlturaDasPernas;

            return alturaDaCadeira;
        }
    }
}
