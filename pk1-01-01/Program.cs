﻿namespace pk1_01_01
{
    internal class Program
    {/*Дан массив строк. Количество элементов массива задается пользователем. Осуществить построчный ввод с консоли данных в этот массив, при этом обрабатывая вводимые данные следующим образом:
•	Если пользователь ввел пустую строку – то вывести ему предупреждение и повторить ввод.
•	Все остальные данные записать в массив без изменений.
Вывести полученный массив на консоль, выделив:
•	значения, которые можно преобразовать к целому числу зеленым цветом
•	значения, которые можно преобразовать к дробному значению – красным цветом
*/
        static void Main(string[] args)
        { // Ввод количества элементов массива
            Console.Write("Введите количество элементов массива: ");
            int kol = int.Parse(Console.ReadLine());

            // Создание массива строк
            string[] mass = new string[kol];

            // Ввод данных в массив с обработкой пустых строк
            for (int i = 0; i < mass.Length; i++)
            {
                while (true)
                {
                    Console.Write($"\nВведите элемент массива под индексом {i}\t ");
                    string a = Console.ReadLine();
                    if (a == "")
                    {
                        Console.WriteLine("Ошибка!Строка не может быть пустой.");
                    }
                    else
                    {
                        mass[i] = a;
                        break;
                    }

                }
            }
            Console.WriteLine($"\nРезультат:");




        }
    }
}

        
    

