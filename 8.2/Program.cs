using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\МИХАИЛ\\Desktop\\ИТМО\\ДПК\\С#\\Numbers.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10;  i++)
                {
                    sw.WriteLine(random.Next(-50, 50));
                }
            }
            int sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine("Сумма составляет {0}", sum);
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
    }
}
