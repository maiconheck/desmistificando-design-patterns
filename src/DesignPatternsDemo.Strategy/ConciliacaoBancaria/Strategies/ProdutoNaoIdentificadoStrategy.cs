using static System.Console;
using DesignPatternsDemo.Strategy.Dummy;

namespace DesignPatternsDemo.Strategy.ConciliacaoBancaria.Strategies
{
    public class ProdutoNaoIdentificadoStrategy : ConciliacaoBancariaStrategy
    {
        public override void Conciliar(
            ILancamentoContaVirtualRepository lancamentoContaVirtualRepository,
            IExtratoBancarioRepository extratoBancarioRepository)
        {            
            WriteLine("Conciliação de Produto não Identificado.");
        }        
    }
}
