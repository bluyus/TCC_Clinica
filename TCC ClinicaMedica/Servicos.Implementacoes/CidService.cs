using ObjetosNegocio;
using Repositorios.Contratos;
using Servicos.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Implementacoes
{
    public class CidService : ICidService
    {
        #region Campos

        private readonly ICidRepository _cidRepository;

        #endregion

        #region Construtor

        public CidService(ICidRepository cidRepository)
        {
            _cidRepository = cidRepository;
        }

        #endregion

        #region Métodos

        public bool Alterar(Cid cid, out string mensagem)
        {
            throw new NotImplementedException();
        }

        public Cid Buscar(int codigoCid)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int codigoCid, out string mensagem)
        {
            throw new NotImplementedException();
        }

        public bool Incluir(Cid cid, out string mensagem)
        {
            throw new NotImplementedException();
        }

        public List<Cid> Listar()
        {
            return _cidRepository.Listar();
        }

        #endregion
    }
}
