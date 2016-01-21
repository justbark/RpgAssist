using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace rpgAssist
{
    class XmlData
    {
        public static void saveData(object iClass, string filename)
        {
            StreamWriter writer = null;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer((iClass.GetType()));
                writer = new StreamWriter(filename);
                xmlSerializer.Serialize(writer, iClass);

            }
            finally
            {
                if (writer != null)
                    writer.Close();
                writer = null;
            }
        }
    }
    public class XmlLoad<T>
    {
        public static Type type;

        public XmlLoad()
        {
            type = typeof(T);
        }

        public T loadData(string filename)
        {
            T result;
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            result = (T)xmlSerializer.Deserialize(fs);
            fs.Close();
            return result;
        }
    }
}
