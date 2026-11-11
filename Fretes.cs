using System;

namespace ListaHeranca
{
    public abstract class Entrega
    {
        public double Distancia { get; set; }

        public Entrega(double distancia)
        {
            Distancia = distancia;
        }

        public abstract double CalcularFrete();
    }

    public class EntregaExpressa : Entrega
    {
        public EntregaExpressa(double distancia) : base(distancia) { }

        public override double CalcularFrete()
        {
            // Taxa base de 5 + 2 por km + taxa extra de 10
            return (Distancia * 2.0) + 10.0;
        }
    }

    public class EntregaEconomica : Entrega
    {
        public EntregaEconomica(double distancia) : base(distancia) { }

        public override double CalcularFrete()
        {
            // Tarifa reduzida: 1.50 por km
            return Distancia * 1.50;
        }
    }

    public class RetiradaLocal : Entrega
    {
        public RetiradaLocal(double distancia) : base(distancia) { }

        public override double CalcularFrete()
        {
            return 0; // Sem custo
        }
    }
}