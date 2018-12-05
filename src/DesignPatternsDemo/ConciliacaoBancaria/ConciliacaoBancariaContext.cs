using System.Collections.Generic;
using DesignPatternsDemo.Dummy;

namespace DesignPatternsDemo.ConciliacaoBancaria
{
    // Composition     
    public class ConciliacaoBancariaContext
    {
        private ILancamentoContaVirtualRepository m_lancamentoContaVirtualRepository;
        private IExtratoBancarioRepository m_extratoBancarioRepository;

        private readonly IEnumerable<ConciliacaoBancariaStrategy> _strategies;

        public ConciliacaoBancariaContext(IEnumerable<ConciliacaoBancariaStrategy> strategies)
        {
            _strategies = strategies;
        }

        public void Conciliar(
            ILancamentoContaVirtualRepository lancamentoContaVirtualRepository,
            IExtratoBancarioRepository extratoBancarioRepository)
        {
            m_lancamentoContaVirtualRepository = lancamentoContaVirtualRepository;
            m_extratoBancarioRepository = extratoBancarioRepository;

            foreach (var strategy in _strategies)
            {
                strategy.Conciliar(lancamentoContaVirtualRepository, extratoBancarioRepository); 
            }
        }
    }
}