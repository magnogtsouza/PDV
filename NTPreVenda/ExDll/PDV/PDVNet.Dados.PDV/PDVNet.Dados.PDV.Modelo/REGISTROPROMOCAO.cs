using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REGISTROPROMOCAO")]
public class REGISTROPROMOCAO
{
	[NotMapped]
	public List<MATERIAISPROMOCAO> ExtensaoProdutos { get; set; }

	[Key]
	public short REG_CODIGO { get; set; }

	public DateTime? REG_INICIO { get; set; }

	public DateTime? REG_FINAL { get; set; }

	[Column(TypeName = "ntext")]
	public string REG_FILTRO { get; set; }

	public double? REG_DESCONTO { get; set; }

	[StringLength(1)]
	public string REG_TIPO { get; set; }

	[StringLength(8)]
	public string REG_MATRICULA { get; set; }

	public DateTime? REG_SEM_VENDA { get; set; }

	public byte? REG_CENTAVOS { get; set; }

	public byte? REG_PERMANENTE { get; set; }

	public byte? REG_EXCLUIDA { get; set; }

	public DateTime? REG_ATUALIZACAO { get; set; }

	public byte? REG_REDE { get; set; }

	public DateTime? REG_CADASTRO { get; set; }

	[StringLength(50)]
	public string REG_OBS { get; set; }

	public byte? REG_TIPO_PRECO { get; set; }

	public byte? REG_TIPO_ALTERACAO { get; set; }

	public byte? REG_LIQUIDACAO { get; set; }

	public byte? REG_GUELTA { get; set; }

	public DateTime? REG_SEM_ALTERACAO { get; set; }

	public byte? REG_RESUMIDO { get; set; }

	public byte? REG_LOJA { get; set; }

	public bool? REG_INATIVO2 { get; set; }

	public byte? REG_LIQUIDACAO2 { get; set; }

	public byte? REG_RESUMIDO2 { get; set; }

	public byte? REG_LOJA2 { get; set; }

	public byte? REG_TABELA { get; set; }

	public byte? REG_TABELA_CUSTO { get; set; }

	public virtual ICollection<MATERIAISPROMOCAO> MATERIAISPROMOCAO { get; set; }
}
