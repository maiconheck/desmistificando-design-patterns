using DesignPatternsDemo.Strategy.Dummy;

namespace DesignPatternsDemo.Strategy.ConciliacaoBancaria
{
    // Compositor
    public abstract class ConciliacaoBancariaStrategy
    {
        public abstract void Conciliar(
            ILancamentoContaVirtualRepository lancamentoContaVirtualRepository,
            IExtratoBancarioRepository extratoBancarioRepository);
    }
}