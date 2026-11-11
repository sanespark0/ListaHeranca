using System;

namespace ListaHeranca
{
    public interface IImprimivel
    {
        void Imprimir();
    }

    public interface IExportavel
    {
        void Exportar();
    }

    public class Relatorio : IImprimivel, IExportavel
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo o Relatório em PDF...");
        }

        public void Exportar()
        {
            Console.WriteLine("Exportando o Relatório para o formato Excel...");
        }
    }

    public class Contrato : IImprimivel
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo o Contrato assinado...");
        }
    }
}