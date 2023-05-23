using System;
using System.IO;
using System.Linq;

namespace pract16_1_oap_mamazhonova
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
                Console.WriteLine("Введите слово для поиска");
                string word = Console.ReadLine()?.ToLower();
                if (string.IsNullOrWhiteSpace(word))
                {
                    Console.WriteLine("Введено пустое значение");
                    return;
                }
                string text = File.ReadAllText("text.txt").ToLower();
                int count = text.Split(' ', '.', ',', ';', ':', '!', '?', '\n', '\r').Count(w => w == word);
                Console.WriteLine($"Были найдены {count} вхождений поискового запроса: \"{word}\"");
            }
           
        }
    }
}
