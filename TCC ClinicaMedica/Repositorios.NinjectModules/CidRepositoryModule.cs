using Ninject.Modules;
using Repositorio.Implementacoes;
using Repositorios.Contratos;

namespace Repositorios.NinjectModules
{
    public class CidRepositoryModule: NinjectModule
    {
        #region Métodos

        public override void Load()
        {
            Bind<ICidRepository>().To<CidRepository>();
        }

        #endregion
    }
}
