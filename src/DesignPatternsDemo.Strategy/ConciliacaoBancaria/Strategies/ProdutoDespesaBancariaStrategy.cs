using static System.Console;
using DesignPatternsDemo.Strategy.Dummy;

namespace DesignPatternsDemo.Strategy.ConciliacaoBancaria.Strategies
{
    public class ProdutoDespesaBancariaStrategy : ConciliacaoBancariaStrategy
    {
        public override void Conciliar(
            ILancamentoContaVirtualRepository lancamentoContaVirtualRepository,
            IExtratoBancarioRepository extratoBancarioRepository)
        {     
            WriteLine("Conciliação de Despesa Bancária.");
        }
    }
}
