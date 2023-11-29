using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
namespace NTPreVenda.Models
{

    public class DeviceInfo
    {
        public string Fingerprint { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public override string ToString()
        {
            return ToXml(this);
        }
        private static string ToXml(DeviceInfo obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UnicodeEncoding(false, false);
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (StringWriter textWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                {
                    serializer.Serialize(xmlWriter, obj);
                }
                return textWriter.ToString();
            }
        }
        public static DeviceInfo XmlParaClasse(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DeviceInfo));
            using (StringReader reader = new StringReader(xml))
            {
                return (DeviceInfo)serializer.Deserialize(reader);
            }
        }

        public static DeviceInfo GetDeviceInfo()
        {
            DeviceInfo deviceInfo = new DeviceInfo()
            {
                Fingerprint = VarGlobais.Data.LoadCfg("fingerprint", Guid.NewGuid().ToString()),
                Name = $"{Microsoft.Maui.Devices.DeviceInfo.Current.Manufacturer} - {Microsoft.Maui.Devices.DeviceInfo.Current.Model}",
                Description = VarGlobais.Data.LoadCfg("Description", "Não identificado"),
            };
            return deviceInfo;
        }
    }
}
