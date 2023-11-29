﻿using LocalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTPreVenda
{
    class VarGlobais
    {
        public static string localCachePath = System.IO.Path.Combine(FileSystem.Current.CacheDirectory, "cache.bin");
        public static LocalData.DataFile Data = Data ?? new DataFile(localCachePath, "202311232354mágnõç", "nacaoCript");
        private static Models.DeviceInfo _DeviceInfo;
        public static void RefreshInfo() { _DeviceInfo = Models.DeviceInfo.GetDeviceInfo(); }
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

    }
}