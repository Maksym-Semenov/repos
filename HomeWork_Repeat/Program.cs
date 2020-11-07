using System;
using System.Net.Http.Headers;

namespace HomeWork_Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите четыре числа");
                float a = float.Parse(Console.ReadLine());
                float b = float.Parse(Console.ReadLine());
                float c = float.Parse(Console.ReadLine());
                float d = float.Parse(Console.ReadLine());
                float rez1;
                float rez2;

                Console.WriteLine("Сумма чисел равна " + (a+b+c+d));
                Console.WriteLine("Произведение чисел равно " + (a * b * c * d));
                Console.WriteLine("Среднее арифметическое чисел равно " + (a + b + c + d) / 4);
                rez1 = (a / b);
                rez2 = (c / d);
                Console.WriteLine("Частное первой пары чисел равно " + rez1);
                Console.WriteLine("Частное второй пары чисел равно " + rez2);
                Console.WriteLine("Количество евро по курсу равно " + (a+b+c+d)/1.1);

                if (b == 0)
                {
                    rez1 = 0;
                    
                }
                else if (d == 0)
                {
                    rez2 = 0;
                }


                Console.ReadLine();

            }

            
        }
        
    }
}
