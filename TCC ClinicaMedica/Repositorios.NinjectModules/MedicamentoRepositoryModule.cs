using Ninject.Modules;
using Repositorio.Implementacoes;
using Repositorios.Contratos;

namespace Repositorios.NinjectModules
{
    public class MedicamentoRepositoryModule: NinjectModule
    {
        #region Métodos

        public override void Load()
        {
            Bind<IMedicamentoRepository>().To<MedicamentoRepository>();
        }

        #endregion
    }
}
