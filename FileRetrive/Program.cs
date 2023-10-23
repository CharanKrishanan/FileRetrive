using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRetrive
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = new FileStream("C:\\Users\\Dell\\Documents\\Practice\\.NET\\FileRetrive\\Students_Data.txt", FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            String data=sr.ReadToEnd();
            Console.WriteLine(data);
            sr.Close();
            sr.Dispose();
            fs.Close();
            fs.Dispose();
            Console.ReadLine();

        }
    }
}
