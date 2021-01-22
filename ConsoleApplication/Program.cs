using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           //ДЗ № 1.
           //Задание 2.

            Console.WriteLine("Введите А:");
            System.Console.Write("А = ");
            var A = int.TryParse(Console.ReadLine(), out var a);
            Console.WriteLine("Введите В:");
            System.Console.Write("В = ");
            var B = int.TryParse(Console.ReadLine(), out var b);

            if (!A)
                {
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine("Вы ввели не число");
                    System.Console.ForegroundColor = ConsoleColor.White;

                }
            if (!B)
                {
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine("Вы ввели не число");
                    System.Console.ForegroundColor = ConsoleColor.White;

                }
            else if (a > b)
            {
                b = a;
                Console.WriteLine("Результат:");
                System.Console.WriteLine($"A = {a}");
                System.Console.WriteLine($"B = {b}");
            }
            else if (b > a)
            {
                a = b;
                Console.WriteLine("Результат:");
                System.Console.WriteLine($"A = {a}");
                System.Console.WriteLine($"B = {b}");
            }
            else if (a == b)
            {
                b = 0;
                a = 0;
                Console.WriteLine("Результат:");
                System.Console.WriteLine($"A = {a}");
                System.Console.WriteLine($"B = {b}");
            }



           //Задание 3.

            Console.Write("Enter operand1 : ");
            double operand1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter operand2 : ");
            double operand2 = Double.Parse(Console.ReadLine());

            Console.Write("Enter operator : ");
            var sign = Console.ReadLine();

            switch (sign)
            {
                case ("+"):
                    System.Console.WriteLine(operand1 + operand2);
                    break;
                case ("-"):
                    System.Console.WriteLine(operand1 - operand2);
                    break;
                case ("*"):
                    System.Console.WriteLine(operand1 * operand2);
                    break;
                default:
                try
                {
                    System.Console.WriteLine(operand1 / operand2);
                }
                catch (System.DivideByZeroException)
                {
                    System.Console.WriteLine("Your Exception notification");
                }
                    break;
            }


            //Задание 4.

            System.Console.Write("Введите число: ");
            var Z = decimal.TryParse(Console.ReadLine(), out var z);

            if (!Z)
                {
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine("Вы ввели не число");
                    System.Console.ForegroundColor = ConsoleColor.White;
                }
            else if (z < 0)
            {
                System.Console.WriteLine("Введено неверное значение, число недолжно быть меньше 0");
            }
            else if (z < 15)
            {
                System.Console.WriteLine($"Число принадлежит промежутку [0 - 14], Ваше число: {z}");
            }
            else if (z < 36)
            {
                System.Console.WriteLine($"Число принадлежит промежутку [15 - 35], Ваше число: {z}");
            }
            else if (z < 50)
            {
                System.Console.WriteLine($"Число принадлежит промежутку [36 - 50], Ваше число: {z}");
            }
            else if (z == 50)
            {
                System.Console.WriteLine($"Число принадлежит промежутку [36 - 50] и [50-100], Ваше число: {z}");
            }
            else if (z < 101)
            {
                System.Console.WriteLine($"Число принадлежит промежутку [51 - 100], Ваше число: {z}");
            }
            else if (z > 100)
            {
                System.Console.WriteLine("Введено неверное значение, число недолжно быть больше 100");
            }
            
            
            //ДЗ № 2.
           //Задание 2.

            System.Console.Write("Введите сумму покупки: ");
            var X = decimal.TryParse(Console.ReadLine(), out var x);


            if (!X)
                {
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine("Вы ввели не число");
                    System.Console.ForegroundColor = ConsoleColor.White;
                }
            else if (x < 0)
            {
                System.Console.WriteLine("Сумма покупки не может быть меньше 0");
            }
            else if (x < 500)
            {
                System.Console.WriteLine($"Сумма к оплате: {x} самон");
            }
            else if (x > 1000)
            {
                var v = x / 100 * 5;
                var y = x - v;
                System.Console.WriteLine($"Ваша скидка 5% составляет: {v} самон");
                System.Console.WriteLine($"Сумма к оплате: {y} самон");  
            }
            else if (x > 500)
            {
                var v = x / 100 * 3;
                var y = x - v;
                System.Console.WriteLine($"Ваша скидка 3% составляет: {v} самон");
                System.Console.WriteLine($"Сумма к оплате: {y} самон");  
            }

            //Задание 3.

            System.Console.Write("Введите первое число: ");
            var N1 = decimal.TryParse(Console.ReadLine(), out var n1);
            System.Console.Write("Введите второе число: ");
            var N2 = decimal.TryParse(Console.ReadLine(), out var n2);
            System.Console.Write("Введите третое число: ");
            var N3 = decimal.TryParse(Console.ReadLine(), out var n3);
            System.Console.Write("Введите четвёртое число: ");
            var N4 = decimal.TryParse(Console.ReadLine(), out var n4);
            if (!N1)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Вы ввели не число");
                System.Console.ForegroundColor = ConsoleColor.White;
            }
            if (!N2)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Вы ввели не число");
                System.Console.ForegroundColor = ConsoleColor.White;
            }
            if (!N3)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Вы ввели не число");
                System.Console.ForegroundColor = ConsoleColor.White;
            }
            if (!N4)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Вы ввели не число");
                System.Console.ForegroundColor = ConsoleColor.White;
            }
            
            else if (n1>n2 || n1>n3 ||n1>n4 ||n2>n3 || n2>n4 || n3>n4)
            {
                if (n1>n2 && n1>n3 && n1>n4)
                {
                    System.Console.WriteLine($"Минимальное число: {n1}");
                }
                if (n2>n1 && n2>n3 && n2>n4)
                {
                    System.Console.WriteLine($"Минимальное число: {n2}");
                }
                if (n3>n1 && n3>n2 && n3>n4)
                {
                    System.Console.WriteLine($"Минимальное число: {n3}");
                }
                if (n4>n1 && n4>n2 && n4>n3)
                {
                    System.Console.WriteLine($"Минимальное число: {n1}");
                }
            }
            else if (n1==n2 && n2==n3 && n3==n4)
            {
                var i = n1 * n2 * n3 * n4;
                System.Console.WriteLine($"Произведение чисел: {i}");
            }
            else
            {
                System.Console.WriteLine("Числа расположены по возрастанию");
            }

            //Задание 4

            System.Console.Write("Введите A: ");
            var i1 = decimal.TryParse(Console.ReadLine(), out var I1);
            System.Console.Write("Введите B: ");
            var i2 = decimal.TryParse(Console.ReadLine(), out var I2);
            System.Console.Write("Введите C: ");
            var i3 = decimal.TryParse(Console.ReadLine(), out var I3);
            var k1 = I1;
            var k2 = I2;
            var k3 = I3;

            if (!i1)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Вы ввели не число");
                System.Console.ForegroundColor = ConsoleColor.White;
            }
            if (!i2)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Вы ввели не число");
                System.Console.ForegroundColor = ConsoleColor.White;
            }
            if (!i3)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Вы ввели не число");
                System.Console.ForegroundColor = ConsoleColor.White;
            }
            if (I1<I2 && I2<I3)
            {
                I1=I3;
                System.Console.WriteLine($"A = :{I1}");
            }
            if (I1<I2 && I3<I2)
                {
                    I1=I2;
                    System.Console.WriteLine($"A = :{I1}");
                }
            if (I1>I2 && I3<I1)
                {
                    System.Console.WriteLine($"A = :{I1}");
                }

            I1 = k1;
            I2 = k2;
            I3 = k3;

            
            if (I2<I1 && I2>I3)
            {
                System.Console.WriteLine($"B = :{I2}");
            }
            if (I1<I2 && I2>I3)
                {
                    I2=I1;
                    System.Console.WriteLine($"B = :{I2}");
                }
            if (I1>I2 && I2<I3)
                {
                    I2=I3;
                    System.Console.WriteLine($"B = :{I2}");
                }

            I1 = k1;
            I2 = k2;
            I3 = k3;

            if (I3<I2 && I3<I1)
                {
                    var L = I3;
                    System.Console.WriteLine($"C = :{I3}");
                }
            if (I3>I2 && I2<I1)
                {
                    I3 = I2;
                    System.Console.WriteLine($"C = :{I3}");
                }
            if (I3>I2 && I2>I1)
                {
                    I3 = I1;
                    System.Console.WriteLine($"C = :{I3}");
                }

            I1 = k1;
            I2 = k2;
            I3 = k3;

            
            if (I1<I2 && I2>I3)
                {
                    I2=I1;
                    System.Console.WriteLine($"B = :{I2}");
                }
            if (I1>I2 && I2<I3)
                {
                    I2=I3;
                    System.Console.WriteLine($"B = :{I2}");
                }
            else
            {
                System.Console.WriteLine($"B = :{I2}");
            }
        }
    }
}
