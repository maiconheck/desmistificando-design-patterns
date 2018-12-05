using static System.Console;
using System.Collections.Generic;
using DesignPatternsDemo.Strategy.Dummy;
using DesignPatternsDemo.Strategy.ConciliacaoBancaria.Strategies;
using DesignPatternsDemo.Strategy.ConciliacaoBancaria;

namespace DesignPatternsDemo.Strategy
{
    class Program
    {
        static void Main()
        {
            ITituloRepository _tituloRepository = null;
            IPagamentoRepository _pagamentoRepository = null;
            IExtratoBancarioRepository _extratoBancarioRepository = null;
            ILancamentoContaVirtualRepository _lancamentoContaVirtualRepository = null;


            var strategies = new List<ConciliacaoBancariaStrategy>
            {
                new ProdutoNaoIdentificadoStrategy(),
                new ProdutoResgateStrategy(),
                new ProdutoRendimentoStrategy(),
                new ProdutoDespesaBancariaStrategy(),
                new CreditoCobrancaStrategy(_tituloRepository),
                new TributoStrategy(_pagamentoRepository),
                new PagamentoEletronicoStrategy(_pagamentoRepository)
            };

            var context = new ConciliacaoBancariaContext(strategies);
            context.Conciliar(_lancamentoContaVirtualRepository, _extratoBancarioRepository);

            ReadKey();
        }
    }
}
