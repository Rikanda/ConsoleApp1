using System;
using System.IO;
using Logo;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1 запись в файл произвольного текста
            string txt = "text1.txt";
            Console.Write("Введите произвольную строку текста: ");
            string a = Console.ReadLine();
            File.WriteAllText(txt, a);



            // задание 2, вызов метода логирования


            logtime.Logs();


        }
    }
}
