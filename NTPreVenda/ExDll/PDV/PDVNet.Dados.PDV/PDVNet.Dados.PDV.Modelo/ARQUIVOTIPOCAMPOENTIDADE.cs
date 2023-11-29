using System;

namespace PDVNet.Dados.PDV.Modelo;

public class ARQUIVOTIPOCAMPOENTIDADE
{
	public short AEN_ARQUIVO_ENTIDADE { get; set; }

	public short AEN_TIPO_CAMPO_DETALHE { get; set; }

	public string AEN_CODIGO_NA_ENTIDADE { get; set; }

	public bool? AEN_INATIVO { get; set; }

	public DateTime? AEN_ATUALIZACAO { get; set; }
}
