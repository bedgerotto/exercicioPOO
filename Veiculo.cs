namespace ConsoleApplication{
    public class Veiculo : IVeiculo
    {
        public string modelo { get; protected set; }
        public string tipo { get; protected set; }
        public string marca { get; protected set; }
        public int ano_fabricacao { get; protected set; }
        public int qtd_rodas { get; protected set; }
        public string cor { get; protected set; }
        public float velocidade { get; protected set; }
        public string placa { get; protected set; }
        
        public void acelera(int km)
        {
            this.velocidade += (float)km;
        }
        public void reduzVelocidade(int km)
        {
            this.velocidade -= (float)km;
        }
        public bool validaPlaca(){
            bool valid = true;
            if (this.placa.Length != 12)
            {
                valid = false;
            }
            return valid;
        }

        public virtual string velocidadeMaxima(int velocidade){
            if ( velocidade > 240) {
                return "Ferrou!";
            }
            return "De Boa...";
        }

    }
}