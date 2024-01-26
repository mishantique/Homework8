using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    internal class Program
    {
        static void Main(string[] args)
        { string full_text, line;
            int symb_amount, words_amount, lines_amount;
            symb_amount = 0;
            lines_amount = 0;
            words_amount = 0;

            string path = @"C:\\Users\\МИХАИЛ\\Desktop\\ИТМО\\ДПК\\С#\\8.3 testing.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine("Исходный текст:");
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                    lines_amount += 1;
                    foreach (char c in line)
                    {
                        symb_amount += 1;
                    }
                    string[] strArray = line.Split();
                    foreach (string s in strArray)
                    {
                        words_amount += 1;
                    }
                }
            }
            //Console.WriteLine("Текст в файле: \n{0}", full_text);
            Console.WriteLine("Количество строк: {0}", lines_amount);
            Console.WriteLine("Количество символов: {0}", symb_amount);
            Console.WriteLine("Количество слов: {0}", words_amount);
            Console.ReadKey(); 
        }
    }
}
