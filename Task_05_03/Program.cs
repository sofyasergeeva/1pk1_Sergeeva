using System;

namespace Task_05_03
{
    internal class Program
    {/*Даны два массива, заполненные символами английского алфавита размером 3*3.
      * Проверить, являются ли матрицы равными, еслида, то вывести сообщение о том, что они равны,
      * если нет, то вывести повторно матрицы с цветовой индикацией только тех элементов, которые равны.
      * (матрицы считаются равными, если их соответствующие элементы равны.*/
        static void Main(string[] args)
        {
            char[,] array1 = new char[3, 3];
            char[,] array2 = new char[3, 3];

            Console.WriteLine("Введите элементы первой матрицы 3x3 (буквы английского алфавита):");
            FillMatrix(array1);

            Console.WriteLine("Введите элементы второй матрицы 3x3 (буквы английского алфавита):");
            FillMatrix(array2);


            bool areEqual = AreMatricesEqual(array1, array2);

            if (areEqual)
            {
                Console.WriteLine("\nМатрицы равны.");
            }
            else
            {
                Console.WriteLine("\nМатрицы не равны. Вывод матриц с цветовой индикацией равных элементов:");
                PrintMatricesWithColor(array1, array2);
            }
        }


        static void FillMatrix(char[,]array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    while (true)
                    {
                        Console.Write($"Элемент [{i},{j}]: ");
                        string input = Console.ReadLine();
                        if (input.Length == 1 && char.IsLetter(input[0]) && ((input[0] >= 'a' && input[0] <= 'z') || (input[0] >= 'A' && input[0] <= 'Z')))
                        {
                            array[i, j] = input[0];
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Введите один символ английского алфавита");
                        }

                    }
                }
            }
        }


        static bool AreMatricesEqual(char[,] array1, char[,] array2)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array1[i, j] != array2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void PrintMatricesWithColor(char[,] array1, char[,] array2)
        {
            Console.WriteLine("Матрица 1:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array1[i, j] == array2[i, j])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write($"{array1[i, j]} ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine("Матрица 2:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array1[i, j] == array2[i, j])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write($"{array2[i, j]} ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
}


        }
    











