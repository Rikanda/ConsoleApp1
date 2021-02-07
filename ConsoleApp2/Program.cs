using System;
using System.IO;



namespace ConsoleApp2
{
    class Programq
    {
        static void Main(string[] args)

                
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);

            string txt = "text2.txt";
            Console.Write("Введите произвольную строку текста: ");
            string a = Console.ReadLine();
            File.WriteAllText(txt, a);
            string txtq = "logtime2.txt";
            string b = "\n" + Convert.ToString(DateTime.Now);
            
            File.AppendAllText(txtq, b);
        }
    }
}
