using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace FirstConsole
{
    class Sere
    {
        public void sereData()
        {
            FileStream fs = new FileStream("D:\\Inatech\\data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, "Visit Chennai");
            fs.Close();
        }
        public void deseData()
        {
            FileStream fs = new FileStream("D:\\Inatech\\data.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            String str =(String) bf.Deserialize(fs);
            Console.WriteLine(str);
            fs.Close();
        }
        public static void Main()
        {
            Sere sobj = new Sere();
            //sobj.sereData();
            sobj.deseData();
            Console.Read();
        }
    }
}
