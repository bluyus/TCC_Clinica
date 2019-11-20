using Ninject.Modules;
using Servicos.Contratos;
using Servicos.Implementacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.NinjectModules
{
    public class MedicamentoServiceModule : NinjectModule
    {
        #region Métodos

        public override void Load()
        {
            Bind<IMedicamentoService>().To<MedicamentoService>();
        }

        #endregion
    }
}
