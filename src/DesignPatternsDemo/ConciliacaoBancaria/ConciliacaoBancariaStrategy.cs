using DesignPatternsDemo.Dummy;

namespace DesignPatternsDemo.ConciliacaoBancaria
{
    // Compositor
    public abstract class ConciliacaoBancariaStrategy
    {
        public abstract void Conciliar(
            ILancamentoContaVirtualRepository lancamentoContaVirtualRepository,
            IExtratoBancarioRepository extratoBancarioRepository);
    }
}