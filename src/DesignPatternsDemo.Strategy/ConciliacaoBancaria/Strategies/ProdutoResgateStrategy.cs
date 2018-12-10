using static System.Console;
using DesignPatternsDemo.Dummy;

namespace DesignPatternsDemo.ConciliacaoBancaria.Strategies
{
    public class ProdutoResgateStrategy : ConciliacaoBancariaStrategy
    {
        public override void Conciliar(
            ILancamentoContaVirtualRepository lancamentoContaVirtualRepository,
            IExtratoBancarioRepository extratoBancarioRepository)
        {     
            WriteLine("Conciliação de Resgate.");
        }
    }
}
