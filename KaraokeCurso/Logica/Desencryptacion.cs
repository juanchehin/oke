using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace KaraokeCurso.Logica
{
  public  class Desencryptacion
    {
        static private AES aes = new AES();
        static public string CnString;
        static string dbcnString;
        static public string appPwdUnique = "KaraokeLuxor369.2020.2344.34234.///";
        public static object checkServer()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            dbcnString = root.Attributes[0].Value;
            CnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
            return CnString;
        }
    }
}
