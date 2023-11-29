using System.Data.Entity;

namespace PDVNet.Dados.PDV.Modelo;

public static class Teste
{
	public static DbSet<dynamic> PegarTabela(this DbContext contexto, string tabela)
	{
		return (DbSet<object>)contexto.GetType().GetProperty(tabela).GetValue(contexto);
	}
}
