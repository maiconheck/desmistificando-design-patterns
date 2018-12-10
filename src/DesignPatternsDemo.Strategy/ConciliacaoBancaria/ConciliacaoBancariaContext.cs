using System.Collections.Generic;
using DesignPatternsDemo.Strategy.Dummy;

namespace DesignPatternsDemo.Strategy.ConciliacaoBancaria
{
    // aka. Composition     
    public class ConciliacaoBancariaContext
    {        
        private readonly IEnumerable<ConciliacaoBancariaStrategy> _strategies;

        public ConciliacaoBancariaContext(IEnumerable<ConciliacaoBancariaStrategy> strategies)
        {
            _strategies = strategies;
        }

        public void Conciliar(
            ILancamentoContaVirtualRepository lancamentoContaVirtualRepository,
            IExtratoBancarioRepository extratoBancarioRepository)
        {
            foreach (var strategy in _strategies)
            {
                strategy.Conciliar(lancamentoContaVirtualRepository, extratoBancarioRepository); 
            }
        }
    }
}