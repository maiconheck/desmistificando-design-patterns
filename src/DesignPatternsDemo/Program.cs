using static System.Console;
using System.Collections.Generic;
using DesignPatternsDemo.ConciliacaoBancaria;
using DesignPatternsDemo.ConciliacaoBancaria.Strategies;
using DesignPatternsDemo.Dummy;

#region Dicas
// Usem a nomenclatura dos 'participantes' (Uncle Bob)
// Uma vez bem implementado, não tenham medo de melhorar.
#endregion

namespace DesignPatternsDemo
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
