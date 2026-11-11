using System;

namespace ListaHeranca
{
    public abstract class ProdutoDigital
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public ProdutoDigital(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Produto: {Nome} - R$ {Preco:F2}");
        }
    }

    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas { get; set; }

        public Ebook(string nome, decimal preco, int paginas) : base(nome, preco)
        {
            QuantidadePaginas = paginas;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Tipo: Ebook | Páginas: {QuantidadePaginas}");
        }
    }

    public class CursoOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public CursoOnline(string nome, decimal preco, int carga) : base(nome, preco)
        {
            CargaHoraria = carga;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Tipo: Curso Online | Carga Horária: {CargaHoraria} horas");
        }
    }
}