using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Demo_Forms
{
    class PlayerManager
    {
        public static void SerializeList(List<Player> lst)
        {
            using (Stream stream = File.Open("player.xml", FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(lst.GetType());
                xs.Serialize(stream, lst);
            }
        }

        public static List<Player> DeserializeList()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Player>));
            List<Player> lst = new List<Player>();
            using (XmlReader reader = XmlReader.Create("player.xml"))
            {
                lst = (List<Player>)xs.Deserialize(reader);
            }
            return lst;
        }
    }
}
