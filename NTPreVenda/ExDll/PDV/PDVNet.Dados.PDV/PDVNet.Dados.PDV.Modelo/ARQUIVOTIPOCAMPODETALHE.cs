using System;

namespace PDVNet.Dados.PDV.Modelo;

public class ARQUIVOTIPOCAMPODETALHE
{
	public short ACD_CODIGO { get; set; }

	public short? ACD_ARQUIVO_TIPO_CAMPO { get; set; }

	public short? ACD_SEQ { get; set; }

	public string ACD_DESCRICAO { get; set; }

	public bool? ACD_INATIVO { get; set; }

	public DateTime? ACD_ATUALIZACAO { get; set; }
}
