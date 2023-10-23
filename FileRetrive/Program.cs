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
            bool ans = File.Exists(@"C:\\Users\\Dell\\Documents\\Practice\\.NET\\FileRetrive\\Students_Data.txt");
            if (ans)
            {
                FileStream fs = null;
                StreamReader sr= null;
                try
                {
                     fs = new FileStream("C:\\Users\\Dell\\Documents\\Practice\\.NET\\FileRetrive\\Students_Data.txt", FileMode.Open, FileAccess.Read);
                     sr = new StreamReader(fs);
                    String data = sr.ReadToEnd();
                    Console.WriteLine(data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sr.Close();
                    sr.Dispose();
                    fs.Close();
                    fs.Dispose();
                }
                
            }
            else
            {
                Console.WriteLine("file does not exist");
            }
            Console.ReadLine();

        }
    }
}
