using System;
using System.IO;
using System.Collections.Generic;

namespace Lab_3
{
    class Task1
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader File = new StreamReader("D:\\2 semestr\\прога\\labki\\labka3\\labka3\\read.txt");
                List<string> list = new List<string> { };
                while (!File.EndOfStream)
                {
                    list.Add(File.ReadLine());
                }
                File.Close();

                list.Reverse();
                StreamWriter File2 = new StreamWriter("D:\\2 semestr\\прога\\labki\\labka3\\labka3\\write.txt");
                for (int i = 0; i < list.Count; i++)
                {
                    File2.WriteLine(list[i]);
                }
                File2.Close();
                Console.WriteLine("Рядки успiшно записанi у файл write.txt");
            }
            catch { Console.WriteLine("Помилка"); }
        }
    }
}
