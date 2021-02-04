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

            // задание 3, запись бинарного файла

            
            string txt2 = "somebytes.bin";

            Console.Write("Ведите набор чисел через пробел: ");
            string numbers = Console.ReadLine();

            string[] ns = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            byte[] test = new byte[ns.Length];

            for (int i = 0; i < ns.Length; i++)
            { 
                test[i] = Convert.ToByte(ns[i]);
                
            }

            File.WriteAllBytes(txt2, test);


            

           
           
            


        }
    }
}
