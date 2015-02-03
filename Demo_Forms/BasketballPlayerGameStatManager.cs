using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Forms
{
    class BasketballPlayerGameStatManager
    {
        public static void SerializeList(List<BasketballPlayerGameStat> lst )
        {
            using (Stream stream = File.Open("stats.xml", FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(lst.GetType());
                xs.Serialize(stream,lst);
            }
        }

        public static List<BasketballPlayerGameStat> DeserializeList()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<BasketballPlayerGameStat>));
            List<BasketballPlayerGameStat> lst = new List<BasketballPlayerGameStat>();
            using (XmlReader reader = XmlReader.Create("stats.xml"))
            {
                lst = (List<BasketballPlayerGameStat>)xs.Deserialize(reader);
            }
            return lst;
        }
    }
}
