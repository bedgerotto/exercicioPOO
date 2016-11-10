using System;
namespace ConsoleApplication{
    public class Moto : Veiculo
    {
        public Moto(string modelo, string marca, int ano_fabricacao, string tipo, string cor)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.ano_fabricacao = ano_fabricacao;
            this.tipo = tipo;
            this.cor = cor;
        }

        public void zerinho()
        {
            Console.WriteLine("Fazendo Zerinho");
        }

        public override string velocidadeMaxima(int velocidade)
        {
            if ( velocidade > 160) {
                return "Ferrou! velocidade acima de 160";
            }
            return "De Boa...";
        }
    }
}