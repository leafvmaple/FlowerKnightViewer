using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FlowerViewer.Models.Data.Xml
{
    public static class XmlFileWriter
    {
        public static void WriteXml<T>(this T saveData, string sFilePath) where T : new()
        {
            var dir = Path.GetDirectoryName(Path.GetFullPath(sFilePath)) ?? "";
            Directory.CreateDirectory(dir);

            FileStream stream = null;
            var serializer = new XmlSerializer(typeof(T));

            try
            {
                stream = new FileStream(sFilePath, FileMode.Create);
                serializer.Serialize(stream, saveData);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                    stream.Dispose();
                }
            }
        }
    }
}
