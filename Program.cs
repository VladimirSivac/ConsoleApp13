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
            string firstLetter = Input("Первая буква транспорта: ");
            string transport = Transport(firstLetter);
            string maxSpeed = MaxSpeed(transport);
            Console.WriteLine($"Вид транспорта: {transport}");
            Console.WriteLine($"Максимальная скорость: {maxSpeed} км/ч!");
            Console.ReadLine();
        }
        static string MaxSpeed(string transport)
        {
            string maxSpeed = "";
            switch (transport)
            {
                case "Автомобиль": maxSpeed = "60"; break;
                case "Велосипед": maxSpeed = "15"; break;
                case "Мотоцикл": maxSpeed = "120"; break;
                case "Самолет": maxSpeed = "1000"; break;
                case "Поезд": maxSpeed = "250"; break;
            }
            return maxSpeed;
        }
        
        static string Transport(string firstLetter)
        {
            string transport = "";
            switch (firstLetter.ToLower())
            {
                case "а": transport = "Автомобиль"; break;
                case "в": transport = "Велосипед"; break;
                case "м": transport = "Мотоцикл"; break;
                case "с": transport = "Самолет"; break;
                case "п": transport = "Поезд"; break;
            }
            return transport;
        }
        
        static string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        
    }
}