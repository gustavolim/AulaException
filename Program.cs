using System;
using System.IO;

namespace AulaException
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int x = 5, y = 0, z;

            //    z = x / y;
            //}
            //catch (SystemException ex)
            //{
            //    throw ex;
            //}


            //try
            //{
            //    int x = 5, y = 0, z;

            //    z = x / y;
            //}
            //catch (SystemException)
            //{
            //    throw new Excecao("Um número não pode ser dividido por zero");
            //}

            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Tente mais tarde.....");
                if (fs != null)
                {
                    fs.Close();
                }
            }

        }
    }
}
