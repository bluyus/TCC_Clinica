using AcessoDados.Contratos;
using Ninject.Modules;

namespace AcessoDados.Modules
{
    public class MainContextModule: NinjectModule
    {
        #region Métodos

        public override void Load()
        {
            Bind<IMainContext>().To<IMainContext>();
        }

        #endregion
    }
}
