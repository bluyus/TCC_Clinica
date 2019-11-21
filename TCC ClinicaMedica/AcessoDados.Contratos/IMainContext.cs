using ObjetosNegocio;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace AcessoDados.Contratos
{
    public interface IMainContext
    {
        DbSet<Cid> CidSet { get; set; }

        DbSet<Exame> ExameSet { get; set; }

        DbSet<Medicamento> MedicamentoSet { get; set; }
    }
}
