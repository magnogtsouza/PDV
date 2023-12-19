using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Dynamic;
using System.Data;
namespace NTPreVenda.db.Models
{
    public abstract class DatabaseItem
    {
        public readonly string PrimaryKey;
        public readonly string[] Fields;
        public readonly string Table;

        public DatabaseItem(string Table = null)
        {
            if (string.IsNullOrEmpty(Table))
            {
                Table = this.GetType().Name;
            }

            this.Table = Table;
            PropertyInfo[] F = this.GetType().GetProperties().Where(x => x.CanWrite && !x.GetMethod.IsVirtual).ToArray();
            PropertyInfo key = F.Where(x => x.CustomAttributes.Any(j => j.AttributeType.Name.Equals("KeyAttribute"))).FirstOrDefault();
            if (key != null)
            {
                PrimaryKey = key.Name;
            }
            Fields = new string[F.Length];
            for (int i = 0; i < F.Length; i++)
            {
                Fields[i] = F[i].Name;
            }
        }

        public abstract bool Insert();

        /// <summary>
        /// Parametros para fazer um Select rapido
        /// </summary>
        /// <param name="limit">Limite de resultados (padrão 100) para deixar ilimitado use 0</param>
        /// <returns></returns>
        public string SelectString(uint limit = 100, IDictionary<string, string> where = null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"SELECT ");

            if (limit > 0)
            {
                sb.Append($"TOP ({limit}) ");
            }

            for (int i = 0; i < Fields.Length; i++)
            {
                sb.Append(Fields[i]);
                if (Fields.Length > (i + 1))
                {
                    sb.Append(',');
                }
            }
            sb.Append($" FROM {Table}");

            if (where != null && where.Count() > 0)
            {
                sb.Append($" WHERE ");
                bool NotFirt = false;
                foreach (var condicao in where)
                {
                    if (NotFirt)
                    {
                        sb.Append(" AND ");
                    }
                    else
                    {
                        NotFirt = true;
                    }
                    sb.Append($" {condicao.Key} LIKE '{condicao.Value}' ");
                }
            }

            if (Fields.Any(x => x.Equals(Table + "_DATA")))
            {
                sb.Append($" order by {Fields.Where(x => x.Equals(Table + "_DATA")).First()} desc ");
            }
            else if (string.IsNullOrEmpty(PrimaryKey))
            {
                sb.Append($" order by {PrimaryKey} desc ");
            }
            else
            {
                sb.Append($" order by {Fields[0]} desc ");
            }
            sb.Append(';');
            return sb.ToString();
        }

        internal async Task<string> ToListExpando(uint limit = 100, IDictionary<string, string> where = null)
        {
            string selec = SelectString(limit, where);
            PropertyInfo[] F = this.GetType().GetProperties().Where(x => x.CanWrite && !x.GetMethod.IsVirtual).ToArray();
            using (SqlConnection cnnT = Pool.GetConnectionNot())
            {
                cnnT.Open();
                using (SqlCommand cmd = new SqlCommand(selec, cnnT))
                {

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        var list = new List<ExpandoObject>();

                        while (reader.Read())
                        {
                            dynamic expando = new ExpandoObject();
                            var expandoDict = expando as IDictionary<string, object>;
                            for (int i = 0; i < F.Length; i++)
                            {
                                var ob = reader.GetValue(i);
                                if (ob is string str)
                                {
                                    ob = str.Trim();
                                }
                                expandoDict.Add(F[i].Name, ob);
                            }
                            list.Add(expando);
                        }
                        string result = Newtonsoft.Json.JsonConvert.SerializeObject(list);
                        return result;
                    }
                }
            }
        }



        public abstract Task<object> GetList(uint limint = 1000, IDictionary<string, string> where = null);
    }
}

