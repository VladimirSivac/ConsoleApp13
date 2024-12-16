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
            int day = Input("Номер месяца: ");
            string season = Season(day);
            Console.WriteLine($"Время года: {season}");
            Console.ReadLine();
        }
        
        static string Season(int day)
        {
            string season = "";
            switch (day)
            {
                case 1: case 2: case 12: season = "Зима"; break;
                case 3: case 4: case 5: season = "Весна"; break;
                case 6: case 7: case 8: season = "Лето"; break;
                case 9: case 10: case 11: season = "Осень"; break;
            }
            return season;
        }
        
        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}