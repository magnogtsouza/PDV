using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTPreVenda.db.Models
{
    class Preco : DatabaseItem
    {

        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string PRE_PRODUTO { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte PRE_TABELA { get; set; }

        public double? PRE_PRECO1 { get; set; }

        public double? PRE_PRECO2 { get; set; }

        public DateTime? PRE_CADASTRO { get; set; }

        public DateTime? PRE_ATUALIZACAO { get; set; }

        [StringLength(8)]
        public string PRE_MATRICULA { get; set; }

        public int? PRE_ASSINA { get; set; }

        public virtual MATERIAIS MATERIAIS { get; set; }
        public override async Task<object> GetList(uint limint = 1000, IDictionary<string, string> where = null)
        {
            string exp = await ToListExpando(limint, where);
            List<Preco> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Preco>>(exp);
            return list;
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }
    }
}
