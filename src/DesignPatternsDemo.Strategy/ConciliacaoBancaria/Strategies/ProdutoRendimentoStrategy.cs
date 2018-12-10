using static System.Console;
using DesignPatternsDemo.Dummy;

namespace DesignPatternsDemo.ConciliacaoBancaria.Strategies
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
