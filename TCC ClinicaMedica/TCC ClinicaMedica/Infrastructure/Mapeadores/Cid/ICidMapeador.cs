using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC_ClinicaMedica.Models;
using ObjetosNegocio;

namespace TCC_ClinicaMedica.Infrastructure.Mapeadores.Cid
{
    public interface ICidMapeador
    {
        CidViewModel Map(ObjetosNegocio.Cid cid);

        ObjetosNegocio.Cid Map(CidViewModel cidViewModel);

        List<CidViewModel> Map(List<ObjetosNegocio.Cid> cidSet);
    }
}