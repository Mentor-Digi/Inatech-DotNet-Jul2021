using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstConsole
{
    class Fyle1
    {
        public void WriteFyle()
        {
            FileStream fs = new FileStream("D:\\Inatech\\Fyle1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.Write("Tamberi & Bashim");
            sw.Flush();
            sw.Close();
            fs.Close();

        }
        public void ReadFyle()
        {
            FileStream fs = new FileStream("D:\\Inatech\\Fyle1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(
                sr.ReadToEnd());
            sr.Close();
            fs.Close();
        }

        public void FyleDetail()
        {
            DirectoryInfo di = new DirectoryInfo("D:\\Inatech");
            Console.WriteLine(di.FullName);
            foreach (var v in di.GetDirectories())
                Console.WriteLine(v.FullName);
            foreach (var v in di.GetFiles())
                Console.WriteLine(v.FullName);
            FileInfo f1 = new FileInfo("D:\\Inatech\\Fyle1.txt");

            Console.WriteLine(f1.Length);
            Console.WriteLine(f1.CreationTime);

            String filepath = "D:\\Inatech\\Fyle1.txt";
            if (File.Exists(filepath))
            {
                Console.WriteLine("File Exists");
            }
           
        }
        public static void Main()
        {
            Fyle1 fobj = new Fyle1();
            fobj.WriteFyle();
            fobj.ReadFyle();
            fobj.FyleDetail();
            Console.Read();

        }
    }
}
