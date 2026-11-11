using System;
using System.Collections.Generic;

namespace ListaHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== EXERCÍCIO 1: Veículos =====");
            Carro carro = new Carro { Marca = "Toyota", Modelo = "Corolla", QuantidadePortas = 4 };
            Motocicleta moto = new Motocicleta { Marca = "Honda", Modelo = "CB 500", Cilindradas = 500 };
            carro.ExibirInformacoes();
            moto.ExibirInformacoes();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("===== EXERCÍCIO 2: Produtos Digitais =====");
            Ebook ebook = new Ebook("C# Avançado", 49.90m, 350);
            CursoOnline curso = new CursoOnline("POO na Prática", 199.90m, 40);
            ebook.ExibirInformacoes();
            curso.ExibirInformacoes();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("===== EXERCÍCIO 3: Jogos =====");
            JogoDigital jogo1 = new JogoDigital("Minecraft", "PC", "Download Digital");
            JogoFisico jogo2 = new JogoFisico("God of War", "PS5", "Mídia Física Blu-Ray");
            jogo1.ExibirInformacoes();
            jogo2.ExibirInformacoes();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("===== EXERCÍCIO 4: Notificações =====");
            Notificacao email = new NotificacaoEmail();
            Notificacao sms = new NotificacaoSMS();
            Notificacao push = new NotificacaoPush();
            email.Enviar();
            sms.Enviar();
            push.Enviar();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("===== EXERCÍCIO 5: Fretes =====");
            List<Entrega> entregas = new List<Entrega>
            {
                new EntregaExpressa(10), // 10 km
                new EntregaEconomica(10),
                new RetiradaLocal(10)
            };
            foreach (var e in entregas)
            {
                Console.WriteLine($"Modalidade: {e.GetType().Name} | Frete: R$ {e.CalcularFrete():F2}");
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("===== EXERCÍCIO 6: Documentos =====");
            Relatorio rel = new Relatorio();
            Contrato contrato = new Contrato();
            
            Console.WriteLine("-- Relatório --");
            rel.Imprimir();
            rel.Exportar();
            
            Console.WriteLine("\n-- Contrato --");
            contrato.Imprimir();
            
            Console.ReadLine();
        }
    }
}