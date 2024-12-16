using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    /// <summary>
    /// Задача 6. Дан признак геометрической фигуры на плоскости: к – круг, п – прямоугольник, т - треугольник. Вывести на экран периметр и площадь заданной фигуры (данные, необходимые для расчетов, запросить у пользователя).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = FigureName(Input("Введите первую букву геометрической фигуры: "));
            
            switch (figure)
            {
                case "Круг":
                    ProcessKr();
                    break;
                case "Прямоугольник":
                    ProcessPr();
                    break;
                case "Треугольник":
                    ProcessTr();
                    break;
            }
            
            Console.ReadLine();
        }
        
        /// <summary>
        /// Для круга
        /// </summary>
        static void ProcessKr()
        {
            double radius = InputDouble("Введите радиус круга: ");
            Output("Круг", KrSquare(radius), KrPerimeter(radius));
        }
        
        /// <summary>
        /// Для прямоугольника
        /// </summary>
        static void ProcessPr()
        {
            double length = InputDouble("Введите длину прямоугольника: ");
            double width = InputDouble("Введите ширину прямоугольника: ");
            Output("Прямоугольник", PrSquare(length, width), PrPerimeter(length, width));
        }

        /// <summary>
        /// Для трегольника
        /// </summary>
        static void ProcessTr()
        {
            double sideA = InputDouble("Введите сторону A треугольника: ");
            double sideB = InputDouble("Введите сторону B треугольника: ");
            double sideC = InputDouble("Введите сторону C треугольника: ");
            Output("Треугольник", TrSquare(sideA, sideB, sideC), TrPerimeter(sideA, sideB, sideC));
        }

        /// <summary>
        /// Ввод строк
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        /// <summary>
        /// Ввод вещественных чисел
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static double InputDouble(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Определение фигуры
        /// </summary>
        /// <param name="firstLetter"></param>
        /// <returns></returns>
        static string FigureName(string firstLetter)
        {
            string figureName = "";
            switch (firstLetter.ToLower())
            {
                case "к": figureName = "Круг"; break;
                case "п": figureName = "Прямоугольник"; break;
                case "т": figureName = "Треугольник"; break;
            }
            return figureName;
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns></returns>
        static double KrSquare(double radius)
        {
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// Периметр круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns></returns>
        static double KrPerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        /// <param name="length">Длина прямоугольника</param>
        /// <param name="width">Ширина прямокгольника</param>
        /// <returns></returns>
        static double PrSquare(double length, double width)
        {
            return length * width;
        }

        /// <summary>
        /// Периметр прямоугольника
        /// </summary>
        /// <param name="length">Длина прямоугольника</param>
        /// <param name="width">Ширина прямокгольника</param>
        /// <returns></returns>
        static double PrPerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <param name="sideA">сторона a</param>
        /// <param name="sideB">сторона b</param>
        /// <param name="sideC">сторона c</param>
        /// <returns></returns>
        static double TrSquare(double sideA, double sideB, double sideC)
        {
            double poluPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(poluPerimeter * (poluPerimeter - sideA) * (poluPerimeter - sideB) * (poluPerimeter - sideC));
        }

        /// <summary>
        /// Периметр треугольника
        /// </summary>
        /// <param name="sideA">сторона a</param>
        /// <param name="sideB">сторона b</param>
        /// <param name="sideC">сторона c</param>
        /// <returns></returns>
        static double TrPerimeter(double sideA, double sideB, double sideC)
        {
            return sideA + sideB + sideC;
        }

        /// <summary>
        /// Вывод данных
        /// </summary>
        /// <param name="figure">Название фигуры</param>
        /// <param name="square">Площадь</param>
        /// <param name="perimeter">Периметр</param>
        static void Output(string figure, double square, double perimeter)
        {
            Console.WriteLine($"Фигура: {figure}");
            Console.WriteLine($"Площадь: {square:F2}");
            Console.WriteLine($"Периметр: {perimeter:F2}");
        }
        
    }
}