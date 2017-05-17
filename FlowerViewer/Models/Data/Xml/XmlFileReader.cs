using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FlowerViewer.Models.Data.Xml
{
    public static class XmlFileReader
    {
        public static T ReadXml<T>(this string sFilePath) where T : new()
        {
            if (sFilePath == null || !File.Exists(sFilePath))
            {
                throw new FileNotFoundException("找不到文件", sFilePath);
            }

            FileStream stream = null;
            T result = new T();

            try
            {
                stream = new FileStream(sFilePath, FileMode.Open);
                var serializer = new XmlSerializer(typeof(T));
                result = (T)serializer.Deserialize(stream);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                    stream.Dispose();
                }
            }

            return result;
        }
    }
}
