using LocalData;
using Microsoft.Data.SqlClient;
using NTPreVenda.db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace NTPreVenda
{
    class VarGlobais
    {
        public static string localCachePath = System.IO.Path.Combine(FileSystem.Current.CacheDirectory, "cache.bin");
        public static LocalData.DataFile Data = Data ?? new DataFile(localCachePath, "202311232354mágnõç", "nacaoCript");
        private static Models.DeviceInfo _DeviceInfo;
        public static void RefreshInfo()
        {
            _DeviceInfo = Models.DeviceInfo.GetDeviceInfo();
        }
        public static Models.DeviceInfo DeviceInfo
        {
            get
            {
                if (_DeviceInfo == null)
                {
                    _DeviceInfo = Models.DeviceInfo.GetDeviceInfo();
                }
                return _DeviceInfo;
            }
        }

        //public static CultureInfo culturaBrasileira = new CultureInfo("pt-BR");

        public static short FilialCodigo { get; set; }

        public static Vendedor[] Vendedores { get; set; }
        public static List<Referencia> Referencias { get; set; }
        public static List<MATERIAIS> Materiais { get; set; }

    }
}
