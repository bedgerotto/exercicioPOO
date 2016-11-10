using System;
namespace ConsoleApplication{
    public class Carro : Veiculo
    {
        public Carro(string modelo, string marca, int ano_fabricacao, string tipo, string cor)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.ano_fabricacao = ano_fabricacao;
            this.tipo = tipo;
            this.cor = cor;
        }

        public void cavalinhoDePau(){
            Console.WriteLine("Dando cavalinho de pau");
        }
        public override string velocidadeMaxima(int velocidade)
        {
            if ( velocidade > 300) {
                return "Ferrou! velocidade acima de 300";
            }
            return "De Boa...";
        }
    }
}