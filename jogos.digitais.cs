using System;

namespace ListaHeranca
{
    public abstract class Jogo
    {
        public string Nome { get; set; }
        protected string Plataforma; // protected: acessível pelas classes filhas

        public Jogo(string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Jogo: {Nome} | Plataforma: {Plataforma}");
        }
    }

    public class JogoDigital : Jogo
    {
        public string Formato { get; set; }

        public JogoDigital(string nome, string plataforma, string formato) : base(nome, plataforma)
        {
            Formato = formato;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Jogo Digital: {Nome} | Plataforma: {Plataforma} | Formato: {Formato}");
        }
    }

    public class JogoFisico : Jogo
    {
        public string TipoMidia { get; set; }

        public JogoFisico(string nome, string plataforma, string tipoMidia) : base(nome, plataforma)
        {
            TipoMidia = tipoMidia;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Jogo Físico: {Nome} | Plataforma: {Plataforma} | Mídia: {TipoMidia}");
        }
    }
}