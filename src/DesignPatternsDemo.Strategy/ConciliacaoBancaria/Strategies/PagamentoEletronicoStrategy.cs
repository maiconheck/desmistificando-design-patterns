using static System.Console;
using DesignPatternsDemo.Dummy;

namespace DesignPatternsDemo.ConciliacaoBancaria.Strategies
{
    public class PagamentoEletronicoStrategy : ConciliacaoBancariaStrategy
    {
        private IPagamentoRepository m_pagamentoRepository;

        public PagamentoEletronicoStrategy(IPagamentoRepository pagamentoRepository)
        {
            m_pagamentoRepository = pagamentoRepository;         
        }

        public override void Conciliar(
            ILancamentoContaVirtualRepository lancamentoContaVirtualRepository,
            IExtratoBancarioRepository extratoBancarioRepository)
        {
            WriteLine("Conciliação de Pagamento Eletrônico.");
        }
    }
}
