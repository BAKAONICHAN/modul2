
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Firsttask();
            //Secondtask();
            //ThirdTask();
            //FourthTask();
            //FifthTask();
            //SixthTask();
            //SeventhTask();
            //EighthTask();
            //NinethTask();
            //TenthTask();


        }
        private static void Firsttask()
        {
            int firstnumber;
            int secondnumber;
            int thirdnumber;
            Console.Write("Enter three numbers->");
            firstnumber = int.Parse(Console.ReadLine());
            secondnumber = int.Parse(Console.ReadLine());
            thirdnumber = int.Parse(Console.ReadLine());
            Console.Write(firstnumber);
            Console.Write(" ");
            Console.Write(secondnumber);
            Console.Write(" ");
            Console.Write(thirdnumber);
            Console.Write(" ");
            Console.ReadLine();
        }
        private static void Secondtask()
        {
            Console.Clear();
            int firstnumber = 5;
            int secondnumber = 10;
            int thirdnumber = 21;
            Console.WriteLine(firstnumber);
            Console.WriteLine(secondnumber);
            Console.WriteLine(thirdnumber);
            Console.ReadLine();
        }
        private static void ThirdTask()
        {
            Console.Clear();
            int centi;//расстояние в сантиметрах
            int metre;//метры
            int centiinmetre = 100;//сантиметров в метре
            Console.WriteLine("Enter the way in centimetres");
            centi = int.Parse(Console.ReadLine());
            metre = centi / centiinmetre;
            Console.Write("If centi is ");
            Console.Write(centi);
            Console.Write(" your metre is ");
            Console.Write(metre);
            Console.ReadLine();
        }
        private static void FourthTask()
        {
            Console.Clear();
            int numberofdays = 234;//
            int daysinweek = 7;//количество дней в неделе
            int week;//неделя
            int days;//дни которые вводит юзер
            Console.WriteLine("Enter the number of days");
            days = int.Parse(Console.ReadLine());
            week = (days + numberofdays) / daysinweek;
            Console.Write("If days is ");
            Console.Write(days);
            Console.Write(" your number week is ");
            Console.Write(week);
            Console.ReadLine();
        }
        private static void FifthTask()
        {
            Console.Clear();
            int number;//число вводимое пользователем обязательно двузначное
            int number_of_decade;//число десятков
            int number_of_unit;//число единиц
            int count_of_decade = 10;//десятки
            int sum;
            int product;
            Console.Write("Enter the number which include two parts |Example 12,32,45|");
            number = int.Parse(Console.ReadLine());
            number_of_decade = number / count_of_decade;
            number_of_unit = number % 10;
            sum = number_of_decade + number_of_unit;
            product = number_of_decade * number_of_unit;
            Console.Write("If number is ");
            Console.Write(number);
            Console.Write(" your number of decade is ");
            Console.Write(number_of_decade);
            Console.Write(" If number is ");
            Console.Write(number);
            Console.Write(" your number of unit is ");
            Console.Write(number_of_unit);
            Console.Write(" The sum is ");
            Console.Write(sum);
            Console.Write(" The product is ");
            Console.Write(product);
            Console.ReadLine();
        }
        private static void SixthTask()
        {
            bool isA = true;
            bool isB = false;
            bool isC = false;
            bool isResult;
            isResult = isA || isB;
            Console.Write("The result if A or B->");
            Console.WriteLine(isResult);
            isResult = isA && isB;
            Console.Write("The result if A and B->");
            Console.WriteLine(isResult);
            isResult = isC || isB;
            Console.Write("The result if C or B->");
            Console.WriteLine(isResult);
            Console.ReadLine();

        }
        private static void SeventhTask()
        {
            Console.Clear();
            int partofsquare;
            int R;
            int areaofsquare;
            int areaofcircle;
            Console.Write("Enter the one part of square ");
            partofsquare = int.Parse(Console.ReadLine());
            Console.Write("Enter the Radius ");
            R = int.Parse(Console.ReadLine());
            areaofsquare = (int)Math.Pow(partofsquare, 2);
            areaofcircle = (int)Math.PI + (int)Math.Pow(R, 2);
            if (areaofsquare > areaofcircle)
            {
                Console.Write("Area of square is bigger than area of circle");
            }
            else
            {
                Console.Write("area of circle is bigger than area of square");
            }
            Console.ReadLine();
        }
        private static void EighthTask()
        {
            int amount_first;
            int weight_first;
            int amount_second;
            int weight_second;
            int density_first;
            int density_second;
            Console.WriteLine("Enter the weight of first element");
            weight_first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weight of second element");
            weight_second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of first element");
            amount_first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of first element");
            amount_second = int.Parse(Console.ReadLine());
            density_first = weight_first / amount_first;
            density_second = weight_second / amount_second;
            if (density_first > density_second)
            {
                Console.Write("The density of first element is more than second");
            }
            else
            {
                Console.Write("The density of second element is more than first");
            }
            Console.ReadLine();

        }
        private static void NinethTask()
        {
            int resistance_first = 123;
            int resistance_second = 154;
            int current_first;
            int current_second;
            int voltage_first;
            int voltage_second;
            Console.WriteLine("Enter the first voltage->");
            voltage_first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second voltage->");
            voltage_second = int.Parse(Console.ReadLine());
            current_first = voltage_first / resistance_first;
            current_second = voltage_second / resistance_second;
            if (current_first > current_second)
            {
                Console.Write("The current on first area is more than on second.");
            }
            else
            {
                Console.Write("The current on second area is more than on first.");
            }
            Console.ReadLine();


        }
        private static void TenthTask()
        {
            int last_number_b;
            int first_number_a;
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Enter the last number which u wanna");
            last_number_b = int.Parse(Console.ReadLine());
            for (int i = 10; i <= last_number_b; i++)
            {
                Console.WriteLine((int)Math.Pow(i, 2));
            }
            Console.WriteLine("Enter the first number which u wanna");
            first_number_a = int.Parse(Console.ReadLine());
            for (int i = 50; first_number_a <= i; first_number_a++)
            {
                Console.WriteLine((int)Math.Pow(first_number_a, 3));
            }
            Console.WriteLine("Enter the first number and last which u wanna");
            first_number_a = int.Parse(Console.ReadLine());
            last_number_b = int.Parse(Console.ReadLine());
            for (; first_number_a <= last_number_b; first_number_a++)
            {
                Console.WriteLine(first_number_a);
            }
            Console.ReadLine();

        }
    }
}




