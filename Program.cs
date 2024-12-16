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
            int day = Input("День недели: ");
            string dayName = Day(day);
            Console.WriteLine($"День недели: {dayName}");
            Console.ReadLine();
        }
        
        static string Day(int day)
        {
            string dayOfTheWeek = "";
            switch(day)
            {
                case 1: dayOfTheWeek = "Понедельник"; break;
                case 2: dayOfTheWeek = "Вторник"; break ;
                case 3: dayOfTheWeek = "Среда"; break;
                case 4: dayOfTheWeek = "Четверг"; break;
                case 5: dayOfTheWeek = "Пятница"; break;
                case 6: dayOfTheWeek = "Суббота"; break;
                case 7: dayOfTheWeek = "Воскресенье"; break;
            }
            return dayOfTheWeek;
        }
        
        static int Input(string message)
        { 
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        
    }
}