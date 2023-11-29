using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace NTPreVenda.db.Models
{
    public abstract class DatabaseItem
    {
        public readonly string PrimaryKey;
        public readonly string[] Fields;
        public readonly string Table;

        public DatabaseItem(string Table)
        {
            this.Table = Table;
            PropertyInfo[] F = this.GetType().GetProperties().Where(x => x.CanWrite).ToArray();
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
        public string SelectString(uint limit = 100)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"SELECT ");

            if (limit > 0)
            {
                sb.Append("TOP (1000) ");
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
            if (string.IsNullOrEmpty(PrimaryKey))
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

    }
}
