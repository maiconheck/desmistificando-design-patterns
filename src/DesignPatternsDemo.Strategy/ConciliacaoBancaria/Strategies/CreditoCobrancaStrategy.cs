using static System.Console;
using DesignPatternsDemo.Strategy.Dummy;


namespace DesignPatternsDemo.Strategy.ConciliacaoBancaria.Strategies
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
            WriteLine("Conciliação de Crédito Cobrança.");
        }
    }
}