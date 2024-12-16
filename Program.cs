using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstLetter = Input("Первая буква предмета: ");
            string subject = Subject(firstLetter);
            Console.WriteLine($"Предмет: {subject}");
            Console.ReadLine();
        }
        
        static string Subject(string firstLetter)
        {
            string subject = "";
            switch (firstLetter.ToLower())
            {
                case "ф": subject = "Физика"; break;
                case "м": subject = "Математика"; break;
                case "и": subject = "История"; break;
                case "г": subject = "География"; break;
                case "б": subject = "Биология"; break;
            }
            return subject;
        }
        static string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        
    }
}