﻿using static System.Console;
using DesignPatternsDemo.Dummy;

namespace DesignPatternsDemo.ConciliacaoBancaria.Strategies
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
