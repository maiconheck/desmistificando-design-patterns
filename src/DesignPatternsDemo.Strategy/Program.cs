using static System.Console;
using System.Collections.Generic;
using DesignPatternsDemo.Strategy.Dummy;
using DesignPatternsDemo.Strategy.ConciliacaoBancaria.Strategies;
using DesignPatternsDemo.Strategy.ConciliacaoBancaria;

#region Dicas
// Usem a nomenclatura dos 'participantes' (Uncle Bob)
// Uma vez bem implementado, não tenha medo de melhorar. Mas não estrague.
// Design patterns vão aumentar a complexidade. Tem que valer a pena.
#endregion

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main()
        {
            #region DI
            ITituloRepository _tituloRepository = null;
            IPagamentoRepository _pagamentoRepository = null;
            IExtratoBancarioRepository _extratoBancarioRepository = null;
            ILancamentoContaVirtualRepository _lancamentoContaVirtualRepository = null; 
            #endregion

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
