using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8_1
{
    // Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Документы/РПП";
            ShowCatalog(path,0);
            Console.ReadKey();
        }
        static void ShowCatalog(string path, int level)
        {
            string[] catalog = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            if (catalog.Count()>0||files.Count()>0)
            {
                string offset = new string('\t', level);
                foreach (string a in files)
                {
                    Console.WriteLine(offset+a);
                }
                foreach (string a in catalog)
                {
                    Console.WriteLine(offset+a);
                    ShowCatalog(a, level+1);
                }
                
            }
        }
    }
}
