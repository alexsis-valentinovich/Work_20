using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
//-метод получает входным параметром переменную типа double;
//-метод возвращает значение типа double, которое является результатом вычисления.
//Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
//-длину окружности по формуле D = 2 * π* R;
//-площадь круга по формуле S = π* R²;
//-объем шара.Формула V = 4 / 3 * π * R³.
namespace Part_1
{
    internal class Program
    {
        delegate double geometria(double rg);

        static double dlina(double r)
        {
            return 2 * Math.PI * Math.Pow(2, r);
        }
        static double square(double r)
        {
            return Math.PI * Math.Pow(2, r);
        }
        static double volume(double r)
        {
            return 4 / 3 * Math.PI * Math.Pow(3, r);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус геометрической фигуры");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            geometria raschet_1 = new geometria(dlina);
            double result_1 = raschet_1(r);
            Console.WriteLine("Длина окружности: {0:f2}", result_1);
            geometria raschet_2 = new geometria(square);
            double result_2 = raschet_2(r);
            Console.WriteLine("Площадь круга: {0:f2}", result_2);
            geometria raschet_3 = new geometria(volume);
            double result_3 = raschet_3(r);
            Console.WriteLine("Объем шара: {0:f2}", result_3);
            Console.ReadKey();
        }
    }
}
