using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CLIENTES
{
	[StringLength(70)]
	public string CLI_NOME { get; set; }

	[StringLength(1)]
	public string CLI_TIPO { get; set; }

	[StringLength(18)]
	public string CLI_CGC { get; set; }

	[StringLength(15)]
	public string CLI_TELEFONE { get; set; }

	[StringLength(15)]
	public string CLI_FAX { get; set; }

	public DateTime? CLI_D_CADASTRO { get; set; }

	[StringLength(6)]
	public string CLI_PREFIXO { get; set; }

	public DateTime? CLI_ATUALIZACAO { get; set; }

	public DateTime? CLI_NASCIMENTO { get; set; }

	[StringLength(50)]
	public string CLI_EMAIL { get; set; }

	[StringLength(15)]
	public string CLI_CELULAR { get; set; }

	[StringLength(15)]
	public string CLI_COMERCIAL { get; set; }

	public short? CLI_FILIAL { get; set; }

	[StringLength(40)]
	public string CLI_PAI { get; set; }

	[StringLength(40)]
	public string CLI_MAE { get; set; }

	public DateTime? CLI_1_COMPRA { get; set; }

	public DateTime? CLI_ULT_COMPRA { get; set; }

	public double? CLI_LIMITE { get; set; }

	[StringLength(15)]
	public string CLI_IDENTIDADE { get; set; }

	public byte? CLI_SEXO { get; set; }

	public short? CLI_PROFISSAO { get; set; }

	public byte? CLI_CLASSIFICACAO { get; set; }

	[StringLength(8)]
	public string CLI_VENDEDOR { get; set; }

	[Key]
	[StringLength(16)]
	public string CLI_CODIGON { get; set; }

	public byte? CLI_ATACADO { get; set; }

	public bool? CLI_INATIVO { get; set; }

	[StringLength(8)]
	public string CLI_MATRICULA { get; set; }

	public byte? CLI_TIPO_CADASTRO { get; set; }

	public bool? CLI_PARCIAL { get; set; }

	public byte? CLI_ENDERECO_PADRAO { get; set; }

	public int? CLI_ASSINA { get; set; }

	public short? CLI_TIPOPESSOA { get; set; }

	public bool? CLI_NEGATIVADO_SCPC { get; set; }

	public bool? CLI_NEGATIVADO { get; set; }

	public bool? CLI_NAO_RECEBE_COBRANCA { get; set; }

	public short? CLI_FILIAL_ALTERACAO { get; set; }

	public virtual ENDERECO ENDERECO { get; set; }

	public virtual ICollection<CAIXA> CAIXA { get; set; }

	public virtual FILIAL FILIAL { get; set; }

	public virtual List<ENDERECO> Enderecos { get; set; }

	[NotMapped]
	public CLIENTESCOMPLEMENTO ExtensaoClientesComplemento { get; set; }

	[NotMapped]
	public CLIENTESOBS ExtensaoClientesObs { get; set; }

	[NotMapped]
	public List<ENDERECO> ExtensaoEnderecos { get; set; }

	[NotMapped]
	public double LimiteCreditoUtilizado { get; set; }
}
