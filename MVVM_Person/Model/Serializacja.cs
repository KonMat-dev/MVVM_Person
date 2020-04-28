using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace MVVM_Person.Model
{
    public static class Serializacja_wczytaj_zapisz
    {
        public static void Zapisz(string path, List<Person> person)
        {
            XmlSerializer serializacja = new XmlSerializer(typeof(List<Person>));

            using (TextWriter textWriter = new StreamWriter(path))
            {
                serializacja.Serialize(textWriter, person);
            }
        }

        public static List<Person> Wczytaj(string path)
        {
            List<Person> footballers = new List<Person>();

            XmlSerializer serializacja = new XmlSerializer(typeof(List<Person>));

            using (TextReader textWriter = new StreamReader(path))
            {
                footballers = serializacja.Deserialize(textWriter) as List<Person>;
            }

            return footballers;
        }
    }
}
