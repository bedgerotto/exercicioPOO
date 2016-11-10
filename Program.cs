using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Instanciando Carro
            Carro carroManeiro = new Carro("Fusca", "VW", 1960, "Carro", "Azul");
            //Instanciando Moto
            Moto motoManeira = new Moto("Yes", "Suzuki", 2008, "Moto", "Preto");

            //Utilizando objeto carro
            Console.WriteLine( carroManeiro.velocidadeMaxima(200) );
            carroManeiro.cavalinhoDePau();

            //Utilizando objeto carro
            Console.WriteLine( motoManeira.velocidadeMaxima(200) );
            motoManeira.zerinho();

            Console.WriteLine("\nE morreu...");
        }
    }
}
