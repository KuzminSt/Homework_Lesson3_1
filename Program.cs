using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson3_1
{
    class Program
    {


        static void Main(string[] args)
        {
            bool answerEnd = false;
            

            

            while (!answerEnd)                                                    //Симуляция основного меню

            {
                Console.Clear();
                Console.WriteLine("Домашняя работа по Уроку 3\nВыберите задание:");
                Console.WriteLine("1.Задание №2\n2.Задание №7\n3.Задание №13\n4.Выход");    //Запрашиваем какой вариант запустить
                string answer1 = Console.ReadLine().Trim().ToLower();
                switch (answer1)
                {
                    case "1": Task1(); break;
                    case "2": Task2(); break;
                    case "3": Task3(); break;
                    case "4": answerEnd = true; break;
                    default: Console.WriteLine("Такой вариант отсутствует"); break;
                }

               
                

               

            }


        }


        //Задание №2. Составить блок-схему алгоритма вычисления площади кольца. Программа должна проверять правильность исходных данных
        static void Task1()
        {

            Console.Clear();
            bool endTask = false;

            do
            {
                double R1 = 0;
                double R2 = 0;
                string answerTemp;
                bool correct1 = false;
                bool correct2 = false;

                do                                                             //Запрашиваем внешний радиус
                {
                    Console.Clear();
                    Console.WriteLine("Введите внешний радиус кольца (см):");
                    answerTemp = Console.ReadLine().Trim().Replace(".", ",");
                    if (double.TryParse(answerTemp, out R1))
                    {
                        correct1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Радиус должен иметь числовое значение!");
                        Console.ReadLine();
                    }
                }
                while (!correct1);

                do                                                            // Запрашиваем внутренний радиус
                {
                    Console.Clear();
                    Console.WriteLine("Введите внутренний радиус кольца (см):");
                    answerTemp = Console.ReadLine().Trim().Replace(".", ",");
                    if (double.TryParse(answerTemp, out R2))
                    {
                        correct2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Радиус должен иметь числовое значение!");
                        Console.ReadLine();
                    }
                }
                while (!correct2);

                if (R1 > R2)                                                    //Проверяем правильность ввода
                {
                    double S1 = Math.PI * Math.Pow(R1, 2);
                    double S2 = Math.PI * Math.Pow(R2, 2);
                    double S = S1 - S2;

                    Console.WriteLine($"Площадь кольца с внешним радиусом {R1} см и внутренним радиусом {R2} составляет {S} квадратных см.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Внешний радиус кольца должен быть больше внутреннего");
                }


                // Данный блок повторяется в каждом методе Task(), но я не знаю, как передавать значение переменной (bool endTask)  между разными методами

                string answer2;                 //Запрашиваем, продолжать ли работать с данным заданием
                bool End1 = false;
                do
                {
                    Console.WriteLine("Продолжить? да / нет");
                    answer2 = Console.ReadLine().Trim().ToLower();
                    switch (answer2)
                    {
                        case "да": End1 = true; break;
                        case "нет": endTask = true; End1 = true; break;
                        default: Console.WriteLine("Такой вариант отсутствует"); break;
                    }
                }
                while (!End1);

            }
            while (!endTask);
        }


        //Задание №7. Составить блок-схему алгоритма вычисления стоимости покупки с учетом скидки. Скидка в 10% предоставляется, если сумма покупки больше 1000 грн. 
        static void Task2()
        {
            bool endTask = false;
            do
            {
                Console.Clear();
                string answerTemp;
                bool correct1 = false;
                double summ;
                double summFin;
                do                                                             //запрашиваем сумму покупки
                {
                    Console.Clear();
                    Console.WriteLine("Вы можете получить скидку в размере 10%, если сумма Вашей покупки более 1000 грн.");
                    Console.WriteLine("Введите сумму покупки (грн):");
                    answerTemp = Console.ReadLine().Trim().Replace(".", ",");
                    if (double.TryParse(answerTemp, out summ))
                    {
                        correct1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Радиус должен иметь числовое значение!");
                        Console.ReadLine();
                    }
                }
                while (!correct1);

                if (summ >= 1000)                                                 //Проверяем условия предоставления скидки
                {
                    summFin = summ / 100 * 110;
                    Console.WriteLine($"Вам предоставлена скидка в размере 10%\nК оплате с учетом скидки: {summFin} грн. ");

                }
                else
                {
                    summFin = summ;
                    Console.WriteLine($"Сумма покупки меньше 1000 грн, скидка не предоставляется\nК оплате : {summFin} грн. ");
                }

                string answer2;                 //Запрашиваем, продолжать ли работать с данным заданием
                bool End1 = false;
                do
                {
                    Console.WriteLine("Продолжить? да / нет");
                    answer2 = Console.ReadLine().Trim().ToLower();
                    switch (answer2)
                    {
                        case "да": End1 = true; break;
                        case "нет": endTask = true; End1 = true; break;
                        default: Console.WriteLine("Такой вариант отсутствует"); break;
                    }
                }
                while (!End1);
            }
            while (!endTask);

        }

        /*Задание №13. Составить блок-схему алгоритма, который сравнивает два введённых с клавиатуры числа. 
         * Программа должна указать, какое число больше, или, если числа равны, вывести соответствующее сообщение.*/
        static void Task3()
        {
            bool endTask = false;
            do
            {
                Console.Clear();
                string answerTemp;
                bool correct1 = false;
                int numStart;

                do                                                            // Запрашиваем два числа
                {
                    Console.Clear();
                    Console.WriteLine("Введите в одной строке два целых числа:");
                    answerTemp = Console.ReadLine().Trim().Replace(" ","");
                    if (Int32.TryParse(answerTemp, out numStart))
                    {
                        correct1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат ввода");
                        Console.ReadLine();
                    }
                }
                while (!correct1);

                double numTemp1 = numStart / 100;              // получаем первое число
                double num1 = Math.Truncate(numTemp1);
                double numTemp2 = num1 * 100;                  //Получаем второе число
                double num2 = numStart - numTemp2;

                if (num1 > num2)
                {
                    Console.WriteLine($"Число {num1} больше числа {num2}");
                    Console.ReadLine();
                }
                else
                {
                    if (num1 == num2)
                    {
                        Console.WriteLine($"Число {num1} равно числу {num2}");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Число {num1} меньше числа {num2}");
                        Console.ReadLine();
                    }
                }


                string answer2;                 //Запрашиваем, продолжать ли работать с данным заданием
                bool End1 = false;
                do
                {
                    Console.WriteLine("Продолжить? да / нет");
                    answer2 = Console.ReadLine().Trim().ToLower();
                    switch (answer2)
                    {
                        case "да": End1 = true; break;
                        case "нет": endTask = true; End1 = true; break;
                        default: Console.WriteLine("Такой вариант отсутствует"); break;
                    }
                }
                while (!End1);
            }
            while (!endTask);
        }


    }
}
