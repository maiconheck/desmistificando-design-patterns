using DesignPatternsDemo.Strategy.Dummy;

using static System.Console;
namespace DesignPatternsDemo.Strategy.ConciliacaoBancaria.Strategies
{
    public class TributoStrategy : ConciliacaoBancariaStrategy
    {
        private IPagamentoRepository m_pagamentosRepository;

        public TributoStrategy(IPagamentoRepository pagamentosRepository)
        {
            m_pagamentosRepository = pagamentosRepository;            
        }

        public override void Conciliar(
            ILancamentoContaVirtualRepository lancamentoContaVirtualRepository,
            IExtratoBancarioRepository extratoBancarioRepository)
        {            
            // ...

            //if (itensExtrato != null && itensExtrato.Any())
            //{
            //    conciliacaoPagamentos.AnalisarTributo(itensExtrato);
            //}

            // ...

            WriteLine("Conciliação de tributo.");
        }
    }
}
