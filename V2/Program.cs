using System;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempoInicio = DateTime.Now;

            Console.WriteLine("Cozinhando");
            var strogonoff = FazerFranguinho();
            var arroz = FazerArroz();

            var duracao = DateTime.Now - tempoInicio;
            Console.WriteLine("Duração = " + duracao);

        }

        private static Arroz FazerArroz(){
            Console.WriteLine("Refogando Cebola");
            Task.Delay(3000).Wait();
            Console.WriteLine("Cebola Refogada");
            Console.WriteLine("Cozinhar Arroz");
            Task.Delay(5000).Wait();
            Console.WriteLine("Arroz Cozido");

            return new Arroz();
        }

        private static Strogonoff FazerFranguinho()
        {
            Console.WriteLine("Refogando Cebola");
            Task.Delay(3000).Wait();
            Console.WriteLine("Cebola Refogada");
            Console.WriteLine("Cozinhar Frango");
            Task.Delay(3000).Wait();
            Console.WriteLine("Frango Cozido");
            Console.WriteLine("Adiciona Molho");
            Task.Delay(1000).Wait();

            return new Strogonoff();
        }

        private class Strogonoff
        {
        }

        private class Arroz
        {
        }
    }
}
