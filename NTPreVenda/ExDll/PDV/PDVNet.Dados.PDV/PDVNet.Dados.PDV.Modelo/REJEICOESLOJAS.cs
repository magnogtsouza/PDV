using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REJEICOESLOJAS")]
public class REJEICOESLOJAS
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int REL_ID { get; set; }

	public short? REL_LOJA_SUPORTE { get; set; }

	public string REL_DOC_NOTA { get; set; }

	public short? REL_REJEICAO { get; set; }

	public string REL_TEXTO { get; set; }

	public DateTime? REL_CADASTRO { get; set; }

	public byte REL_TIPO_NF { get; set; }

	public byte REL_SISTEMA { get; set; }

	public DateTime? REL_VERSAO { get; set; }

	public DateTime REL_RESOLVIDO { get; set; }

	public DateTime REL_RESOLVIDO_VERSAO { get; set; }

	[MaxLength(8)]
	public string REL_RESOLVIDO_MATRICULA { get; set; }

	public string REL_RESOLVIDO_OBSERVACAO { get; set; }

	public string REL_COMPUTADOR { get; set; }

	public DateTime REL_CADASTRO_NOTA { get; set; }

	public string REL_USUARIO { get; set; }

	public Guid? REL_COMPUTADOR_GUID { get; set; }

	public string REL_NCM { get; set; }

	public string REL_XML { get; set; }

	public string REL_AUDIT_TELA { get; set; }
}
