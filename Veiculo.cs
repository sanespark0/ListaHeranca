using System;

namespace ListaHeranca
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Veículo: {Marca} {Modelo}");
        }
    }

    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo} - {QuantidadePortas} portas");
        }
    }

    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Moto: {Marca} {Modelo} - {Cilindradas} cilindradas");
        }
    }
}