using static System.Console;
using DesignPatternsDemo.Strategy.Dummy;

namespace DesignPatternsDemo.Strategy.ConciliacaoBancaria.Strategies
{
    public class ProdutoRendimentoStrategy : ConciliacaoBancariaStrategy
    {
        public override void Conciliar(
            ILancamentoContaVirtualRepository lancamentoContaVirtualRepository,
            IExtratoBancarioRepository extratoBancarioRepository)
        {     
            WriteLine("Conciliação de Rentabilidade.");
        }
    }
}
