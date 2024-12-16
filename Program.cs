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
            int month = Input("Номер месяца: ");
            string monthNum = Month(month);
            Console.WriteLine($"Месяц: {monthNum}");
            Console.ReadLine();
        }
        
        static string Month(int monthNumber)
        {
            string month = "";
            switch(monthNumber)
            {
                case 1: month = "Январь"; break;
                case 2: month = "Февраль"; break;
                case 3: month = "Март"; break;
                case 4: month = "Апрель"; break;
                case 5: month = "Май"; break;
                case 6: month = "Июнь"; break;
                case 7: month = "Июль"; break;
                case 8: month = "Август"; break;
                case 9: month = "Сентябрь"; break;
                case 10: month = "Октябрь"; break;
                case 11: month = "Ноябрь"; break;
                case 12: month = "Декабрь"; break;
                
            }
            return month;
        }
        
        static int Input(string message)
        { 
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        
    }
}