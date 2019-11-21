using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AcessoDados.Contratos;
using ObjetosNegocio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AcessoDados.Implementacoes
{
    public class MainContext : DbContext, IMainContext
    {

        #region Construtores

        public MainContext() : base("ClinicaContext")
        {
        }

        #endregion

        #region Métodos

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties()
                .Where(p => p.Name == "Id")
                .Configure(p => p.IsKey().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity));

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        #endregion

        #region Propriedades

        public DbSet<Cid> CidSet { get; set; }
        public DbSet<Exame> ExameSet { get; set; }
        public DbSet<Medicamento> MedicamentoSet { get; set; }

        #endregion

    }
}
