using ObjetosNegocio;
using System.Collections.Generic;

namespace Servicos.Contratos
{
    public interface ICidService
    {
        #region Métodos

        List<Cid> Listar();

        bool Incluir(Cid cid, out string mensagem);

        bool Alterar(Cid cid, out string mensagem);

        bool Excluir(int codigoCid, out string mensagem);

        Cid Buscar(int codigoCid);

        #endregion
    }
}
