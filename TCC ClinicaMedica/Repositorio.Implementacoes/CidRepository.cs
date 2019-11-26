using AcessoDados.Contratos;
using ObjetosNegocio;
using Repositorios.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Implementacoes
{
    public class CidRepository : ICidRepository
    {
        private readonly IMainContext _context;

        public CidRepository(IMainContext context)
        {
            _context = context;
        }

        public List<Cid> Listar()
        {
            return _context.CidSet.ToList();
        }
    }
}
