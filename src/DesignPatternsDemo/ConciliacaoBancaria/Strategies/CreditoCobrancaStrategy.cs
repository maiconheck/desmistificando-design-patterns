using static System.Console;
using DesignPatternsDemo.Dummy;

namespace DesignPatternsDemo.ConciliacaoBancaria.Strategies
{
    public class CreditoCobrancaStrategy : ConciliacaoBancariaStrategy
    {
        private ITituloRepository _tituloRepository;

        public CreditoCobrancaStrategy(ITituloRepository tituloRepository)
        {
            _tituloRepository = tituloRepository;
        }        

        public override void Conciliar(
            ILancamentoContaVirtualRepository lancamentoContaVirtualRepository,
            IExtratoBancarioRepository extratoBancarioRepository)
        {            
            WriteLine("Conciliação de crédito cobrança.");
        }
    }
}