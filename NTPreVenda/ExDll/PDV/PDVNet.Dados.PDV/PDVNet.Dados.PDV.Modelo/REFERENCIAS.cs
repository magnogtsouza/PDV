using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class REFERENCIAS
{
	[NotMapped]
	public string ExtensaoColecaoDescricao { get; set; }

	[NotMapped]
	public string ExtensaoNCMNCM { get; set; }

	[NotMapped]
	public string ExtensaoCompradorDescricao { get; set; }

	public short REF_COLECAO { get; set; }

	[Key]
	[Column(Order = 0)]
	[StringLength(12)]
	public string REF_REFERENCIA { get; set; }

	[StringLength(255)]
	public string REF_DESCRICAO { get; set; }

	public DateTime? REF_CADASTRO { get; set; }

	public short? REF_MATERIA { get; set; }

	public short? REF_GRUPO { get; set; }

	public byte? REF_TIPO { get; set; }

	public short? REF_LINHA { get; set; }

	public double? REF_PESO_BRUTO { get; set; }

	public double? REF_PESO_LIQUIDO { get; set; }

	public double? REF_IPI { get; set; }

	public byte REF_CODIGO_GRADE { get; set; }

	[StringLength(6)]
	public string REF_FORNECEDOR { get; set; }

	[StringLength(20)]
	public string REF_REFERENCIA_FORNECEDOR { get; set; }

	public short? REF_MODELO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte REF_REDE { get; set; }

	[Column(TypeName = "ntext")]
	public string REF_OBS { get; set; }

	public short? REF_COMPRADOR { get; set; }

	public DateTime REF_ATUALIZACAO { get; set; }

	public bool? REF_LIQUIDACAO2 { get; set; }

	public bool? REF_CONSIGNADO2 { get; set; }

	public bool? REF_INATIVO2 { get; set; }

	public bool? REF_REPETICAO2 { get; set; }

	public bool? REF_SERIE2 { get; set; }

	[StringLength(30)]
	public string REF_DESC2 { get; set; }

	public bool? REF_DIFERENTE { get; set; }

	public byte? REF_PRODUCAO { get; set; }

	[StringLength(3)]
	public string REF_CLASSIFICACAO { get; set; }

	public bool? REF_NAO_CONTROLA { get; set; }

	public bool? REF_DECIMAL { get; set; }

	public short? REF_NCM { get; set; }

	public int? REF_ASSINA { get; set; }

	public double? REF_ALTURA { get; set; }

	public double? REF_LARGURA { get; set; }

	public double? REF_PROFUNDIDADE { get; set; }

	public bool? REF_SITE { get; set; }

	public double? REF_MVA { get; set; }

	public short? REF_COBERTURA { get; set; }

	public bool? REF_SERVICO { get; set; }

	public short? REF_CEST { get; set; }

	public bool? REF_BALANCA { get; set; }

	public byte? REF_NFEORIGEM { get; set; }

	public double? REF_COMISSAO { get; set; }

	public double? REF_GUELTA { get; set; }

	public short? REF_TIPOPRODUTO { get; set; }

	public byte? REF_UNIDADE2 { get; set; }

	public bool? REF_NAO_ENVIARLOJA { get; set; }

	public bool? REF_RFID { get; set; }

	public bool? REF_PEDIDO_VENDA { get; set; }

	public bool? REF_CONTROLA_LOTE { get; set; }

	public short? REF_DIAS_VALIDADE { get; set; }

	public virtual ICollection<MATERIAIS> MATERIAIS { get; set; }

	public virtual COLECOES COLECOES { get; set; }

	public virtual LINHA LINHA { get; set; }

	public virtual MODELOS MODELOS { get; set; }

	public virtual UNIDADES UNIDADES { get; set; }

	public virtual MATERIAPRIMA MATERIAPRIMA { get; set; }

	public virtual ICollection<TRIBUTO> TRIBUTO { get; set; }
}
