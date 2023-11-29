using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MANIFESTOELETRONICO")]
public class MANIFESTOELETRONICO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string MAE_DOC { get; set; }

	public short? MAE_FILIAL { get; set; }

	public short? MAE_SERIE { get; set; }

	public int? MAE_NUMERO { get; set; }

	public DateTime? MAE_EMISSAO { get; set; }

	public short? MAE_VEICULO { get; set; }

	public short? MAE_QUANTIDADE { get; set; }

	public double? MAE_VALOR { get; set; }

	public byte? MAE_PESO_TIPO { get; set; }

	public double? MAE_PESO { get; set; }

	[StringLength(50)]
	public string MAE_MDFE_CHAVE { get; set; }

	[StringLength(15)]
	public string MAE_MDFE_PROTOCOLO { get; set; }

	public DateTime? MAE_MDFE_DATA_PROTOCOLO { get; set; }

	public DateTime? MAE_CADASTRO { get; set; }

	public DateTime? MAE_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string MAE_MATRICULA { get; set; }

	[StringLength(100)]
	public string MAE_OBSERVACAO { get; set; }

	public short? MAE_STATUS { get; set; }

	[NotMapped]
	public string UsuarioNome { get; set; }

	[NotMapped]
	public string StatusDescricao { get; set; }

	[NotMapped]
	public virtual ICollection<MANIFESTOELETRONICOCHAVE> Chaves { get; set; }

	[NotMapped]
	public virtual ICollection<MANIFESTOELETRONICOCONDUTOR> Condutores { get; set; }

	[NotMapped]
	public virtual ICollection<MANIFESTOELETRONICOPERCURSO> Percursos { get; set; }

	[NotMapped]
	public VEICULO Veiculo { get; set; }
}
