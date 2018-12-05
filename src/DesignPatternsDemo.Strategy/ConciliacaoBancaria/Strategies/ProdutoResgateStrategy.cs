using static System.Console;
using DesignPatternsDemo.Strategy.Dummy;

namespace DesignPatternsDemo.Strategy.ConciliacaoBancaria.Strategies
{
    public class ProdutoResgateStrategy : ConciliacaoBancariaStrategy
    {
        public override void Conciliar(
            ILancamentoContaVirtualRepository lancamentoContaVirtualRepository,
            IExtratoBancarioRepository extratoBancarioRepository)
        {     
            WriteLine("Conciliação de resgate.");
        }
    }
}
