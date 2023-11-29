using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.ModelConfiguration.Conventions;
//using PDVNet.Dados.Nucleo;

namespace PDVNet.Dados.PDV.Modelo;

public class ModeloPDV_Auxiliar : DbContext
{
	public virtual DbSet<IMAGEM> IMAGEM { get; set; }

	static ModeloPDV_Auxiliar()
	{
		//DbInterception.Add(new EntityCommandInterceptor());
	}

	public ModeloPDV_Auxiliar()
		: base("name=ModeloPDV_Auxiliar")
	{
		base.Configuration.AutoDetectChangesEnabled = false;
		base.Configuration.LazyLoadingEnabled = false;
	}

	public ModeloPDV_Auxiliar(string stringConexao)
		: base(stringConexao)
	{
		base.Configuration.AutoDetectChangesEnabled = false;
		base.Configuration.LazyLoadingEnabled = false;
	}

	protected override void OnModelCreating(DbModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		modelBuilder.Entity<IMAGEM>().Property((IMAGEM e) => e.IMA_CODIGO).IsFixedLength()
			.IsUnicode(false);
		modelBuilder.Entity<IMAGEM>().Property((IMAGEM e) => e.IMA_EXTENSAO).IsFixedLength()
			.IsUnicode(false);
		modelBuilder.Entity<IMAGEM>().Property((IMAGEM e) => e.IMA_MATRICULA).IsFixedLength()
			.IsUnicode(false);
	}
}
