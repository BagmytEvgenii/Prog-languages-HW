﻿// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// // MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки, возможно ли 
// умножения двух матриц matrixA и matrixB. Если число столбцов в матрице matrixA не 
// равно числу строк в матрице matrixB, то выводится сообщение "It is impossible to multiply." В противном 
// случае, вызывается метод MatrixMultiplication для умножения матриц, и результат выводится с помощью метода PrintMatrix.

// // MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения двух матриц 
// matrixA и matrixB. Метод возвращает новую матрицу, которая представляет собой результат 
// умножения матрицы matrixA на матрицу matrixB.

// // PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.

// // Если аргументы не переданы, программа использует матрицы по умолчанию. 
// Если аргументы переданы, программа парсит их в двумерные массивы целых чисел и выполняет умножение матриц.


// // using System;

// public class Answer
// {
//     public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
//     {
//         if (matrixA.GetLength(1) != matrixB.GetLength(0))
//         {
//             Console.WriteLine("It is impossible to multiply.");
//         }
//         else
//         {
//             int[,] multiplicative = MatrixMultiplication(matrixA, matrixB);
//             PrintMatrix(multiplicative);
//         }
//     }

//     public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
//     {
//         int[,] multiplicative = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//         for (int i = 0; i < multiplicative.GetLength(0); i++)
//         {
//             for (int j = 0; j < multiplicative.GetLength(1); j++)
//             {
//                 for (int k = 0; k < matrixA.GetLength(1); k++)
//                 {
//                     multiplicative[i, j] += matrixA[i, k] * matrixB[k, j];
//                 }
//             }
//         }
//         return multiplicative;
//     }

//     public static void PrintMatrix(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static void Main(string[] args)
//     {
//         int[,] matrix;

//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,]
//             {
//                 {5, 2},
//                 {8, 1}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         PrintMatrix(matrix);

//         int[,] matrixB = {
//             {5, 6},
//             {7, 8}
//         };

//         Console.WriteLine("\nMatrix B:");
//         PrintMatrix(matrixB);

//         Console.WriteLine("\nMultiplication result:");

//         MultiplyIfPossible(matrix, matrixB);
//     }
// }








// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс Answer, который содержит следующие статические методы:

// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной 
// строке row матрицы matrix. Метод принимает двумерный массив целых чисел matrix и 
// номер строки row, а возвращает целое число - сумму элементов в данной строке.

// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. 
// Метод принимает двумерный массив целых чисел matrix и возвращает массив из 
// двух элементов: номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.


// using System;

// public class Answer
// {
//     public static int SumOfRow(int[,] matrix, int row)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[row, j];
//         }
//         return sum;
//     }

//     public static int[] MinimumSumRow(int[,] matrix)
//     {
//         int[] RowNumberAndSum = new int[2];
//         RowNumberAndSum[1] = SumOfRow(matrix, RowNumberAndSum[0]);
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             if (RowNumberAndSum[1] > SumOfRow(matrix, i))
//             {
//                 RowNumberAndSum[0] = i;
//                 RowNumberAndSum[1] = SumOfRow(matrix, RowNumberAndSum[0]);
//             }
//         }
//         return RowNumberAndSum;
//     }

//     public static void Main(string[] args)
//     {
//         int[,] matrix;
//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,]
//             {
//                 {5, 2, 9},
//                 {8, 1, 4},
//                 {6, 7, 3}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }

//         int[] minSumRow = MinimumSumRow(matrix);

//         Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

//         int rowToSum = 1; 
//         int sum = SumOfRow(matrix, rowToSum);
//         Console.WriteLine($"Сумма элементов в строке {rowToSum + 1}: {sum}");

//     }
// }













// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. Он принимает на вход 
// двумерный массив целых чисел matrix и выводит его элементы в виде таблицы.

// SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. 
// Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку 
// матрицы так, чтобы элементы в каждой строке шли по убыванию.

// using System;

// public class Answer
// {
//     public static void PrintMatrix(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static void SortRowsDescending(int[,] matrix)
//     {
//         int j = 0;
//         int k = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)               //checking all rows
//         {
//             for (j = 0; j < matrix.GetLength(1); j++)                //Starting from each element in column
//             {
//                 int max = j;
//                 for (k = j; k < matrix.GetLength(1); k++)            // checking if any number is greater than in j-position
//                 {
//                     if (matrix[i, max] < matrix[i, k])                         // if new max if found remeber its position                                          
//                     {
//                         max = k;
//                     }
//                 }
//                 var temp = matrix[i, max];                      // Swap max and current j-position
//                 matrix[i, max] = matrix[i, j];
//                 matrix[i, j] = temp;
//             }
//         }
//     }


//     public static void Main(string[] args)
//     {
//         int[,] matrix;
//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,] {
//                 {5, 2, 9},
//                 {8, 1, 4},
//                 {6, 7, 3}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 if (elements.Length != matrix.GetLength(1))
//                 {
//                     Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
//                     return;
//                 }
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         PrintMatrix(matrix);

//         SortRowsDescending(matrix);

//         Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
//         PrintMatrix(matrix);
//     }
// }