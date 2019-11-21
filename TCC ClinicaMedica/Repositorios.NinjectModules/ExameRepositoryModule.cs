using Ninject.Modules;
using Repositorio.Implementacoes;
using Repositorios.Contratos;

namespace Repositorios.NinjectModules
{
    public class ExameRepositoryModule: NinjectModule
    {
        #region Métodos

        public override void Load()
        {
            Bind<IExameRepository>().To<ExameRepository>();
        }

        #endregion
    }
}
