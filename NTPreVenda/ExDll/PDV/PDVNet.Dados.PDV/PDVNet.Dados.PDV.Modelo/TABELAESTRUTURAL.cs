using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TABELAESTRUTURAL")]
public class TABELAESTRUTURAL
{
	[Key]
	public short TAE_CODIGO { get; set; }

	[StringLength(50)]
	public string TAE_NOME { get; set; }

	public byte? TAE_EXPORTACAO { get; set; }

	public bool? TAE_SEPARA_FILIAL { get; set; }

	public byte? TAE_ORDEM { get; set; }

	[StringLength(50)]
	public string TAE_COMPLEMENTO { get; set; }

	[StringLength(20)]
	public string TAE_CAMPO { get; set; }

	public bool? TAE_DISTINCT { get; set; }

	[StringLength(30)]
	public string TAE_LINK_DESCRICAO { get; set; }

	[StringLength(50)]
	public string TAE_LINK2 { get; set; }

	public bool? TAE_BCP { get; set; }

	[StringLength(50)]
	public string TAE_TABELA_PARTIDA { get; set; }

	[StringLength(10)]
	public string TAE_CAMPO_FILIAL_EXTERNA { get; set; }

	public bool? TAE_PESQUISAR_FILIAL { get; set; }

	public bool? TAE_INATIVO { get; set; }

	[StringLength(30)]
	public string TAE_ORDENAR { get; set; }

	public byte? TAE_NEGOCIO { get; set; }

	[StringLength(30)]
	public string TAE_DESCRICAO { get; set; }

	public byte? TAE_TESTAR_DUPLICIDADE { get; set; }

	[StringLength(50)]
	public string TAE_CAMPO_DUPLICIDADE { get; set; }

	[StringLength(50)]
	public string TAE_CAMPOS_NAO_ATUALIZAR { get; set; }

	[StringLength(15)]
	public string TAE_CAMPO_ATUALIZACAO { get; set; }

	public bool? TAE_FILIAL99 { get; set; }

	public byte? TAE_REDE { get; set; }

	[StringLength(15)]
	public string TAE_CAMPO_REDE { get; set; }

	public bool? TAE_NAO_EXPORTAR_FRANQUIA { get; set; }

	[StringLength(10)]
	public string TAE_PREFIXO { get; set; }

	public bool? TAE_EXPORTAR_TODAS { get; set; }

	[StringLength(255)]
	public string TAE_INSTRUCAO { get; set; }

	public bool? TAE_BASICA { get; set; }

	public short? TAE_PAI { get; set; }

	public bool? TAE_TRIGGER { get; set; }

	public bool? TAE_ORIGEM { get; set; }

	[StringLength(20)]
	public string TAE_CAMPO_DOC { get; set; }

	[StringLength(20)]
	public string TAE_CAMPO_IDENTITY { get; set; }

	[NotMapped]
	public List<TABELAESTRUTURAL> TabelaEstruturalDependente { get; set; }
}
