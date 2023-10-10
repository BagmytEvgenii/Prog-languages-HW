// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размерность массива), 
// а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.
// // Также, задайте метод PrintArray, который выводил бы массив на экран.
// // Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j] с двумя знаками после 
// запятой (f2) и добавления символа табуляции (\t) после каждого элемента матрицы. Таким образом, каждый элемент 
// матрицы будет разделен символом табуляции при выводе.

// m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10

// 0,5    7    -2    -0,2
// 1    -3,3    8    -9,9
// 8    7,8    -7,1    9

// using System;

// public class Answer {
//   public static double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
//       // Введите свое решение ниже
//     double[,] randArr = new double[m,n];
//       for (int i = 0; i < m; i++){
//          for (int j = 0; j < n; j++){
//            randArr[i, j] = Math.Round((new Random().NextDouble()) * (maxLimitRandom + 0.001 - minLimitRandom) + minLimitRandom, 1);
//          }
//       }
//       return randArr;
//   }

//   public static void PrintArray(double[, ] matrix) {
//       // Введите свое решение ниже
//       for (int i = 0; i < matrix.GetLength(0); i++){
//          for (int j = 0; j < matrix.GetLength(1); j++){
//            System.Console.Write(matrix[i, j] + " ");
//          }
//         System.Console.WriteLine(); 
//       }
//   }

//   // Не удаляйте и не меняйте метод Main! 
//   public static void Main(string[] args) {
//     int m, n, minLimitRandom, maxLimitRandom;

//     if (args.Length >= 4) {
//       m = int.Parse(args[0]);
//       n = int.Parse(args[1]);
//       minLimitRandom = int.Parse(args[2]);
//       maxLimitRandom = int.Parse(args[3]);

//       double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

//         // Выберем случайные индексы трех элементов матрицы array
//         int row1 = new Random().Next(0, m);
//         int col1 = new Random().Next(0, n);
//         int row2 = new Random().Next(0, m);
//         int col2 = new Random().Next(0, n);
//         int row3 = new Random().Next(0, m);
//         int col3 = new Random().Next(0, n);

//         // Проверяем, являются ли выбранные элементы дробными числами
//         bool isFractional1 = (array[row1, col1] % 1) != 0;
//         bool isFractional2 = (array[row2, col2] % 1) != 0;
//         bool isFractional3 = (array[row3, col3] % 1) != 0;

//         // Если два из трех элементов не являются дробными числами, то бросаем исключение
//         if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
//         {
//             Console.WriteLine("Все ок!");
//         }
//         else
//         {
//             throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
//         }
//     } else {
//       m = 3;
//       n = 4;
//       minLimitRandom = -10;
//       maxLimitRandom = 10;
      
//       double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
//       PrintArray(result);
//     }
//   }
// }













// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.
// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся 
// на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, 
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// // Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
// // Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице. 
// Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. 
// Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в 
// указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

// // Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. 
// Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из 
// метода FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, 
// вывести на экран "The number in [{x}, {y}] is {значение}".

// // Пример

// n = 3;
// m = 4;
// k = 2;
// x = 8;
// y = 3;

// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);

// /*
// 1   3   5   7   
// 9   11  13  15  
// 17  19  21  23  
// There is no such index
// */

// n = 4;
// m = 5;
// k = 3;
// x = 2;
// y = 2;

// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);

// /*
// 1   4   7   10  13  
// 16  19  22  25  28  
// 31  34  37  40  43  
// 46  49  52  55  58  
// The number in [2, 2] is 19
// */

// Решение

// using System;

// public class Answer {
//     public static void PrintArray (int [,] matrix)
//     {
//       // Введите свое решение ниже
//     for (int i = 0; i < matrix.GetLength(0); i++){
//          for (int j = 0; j < matrix.GetLength(1); j++){
//            System.Console.Write($"{matrix[i, j]}\t");
//          }
//         System.Console.WriteLine();
//       }
//     }
  
//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//       // Введите свое решение ниже
//     int[,] matrix = new int[n,m];
//       matrix[0, 0] = 1;
//       for (int i = 0; i < matrix.GetLength(0); i++){
//          for (int j = 1; j < matrix.GetLength(1); j++){
//            matrix[i, j] = matrix[i, j - 1] + k; 
//          }
//         if (i + 1 < matrix.GetLength(0))
//           matrix[i + 1, 0] = matrix[i, matrix.GetLength(1) - 1] + k;
//       }
//       return matrix;
//     }
  
//     public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
//     {  
//       // Введите свое решение ниже
//       int[] pos = new int[1];
//       if (rowPosition - 1 < matrix.GetLength(0) && columnPosition - 1< matrix.GetLength(1)) {
//         pos[0] = Convert.ToInt32(matrix.GetValue(rowPosition - 1, columnPosition - 1));
//       } else {
//         pos[0] = 0;
//       }
//     return pos;
//     }

//     public static void PrintCheckIfError (int[] results, int X, int Y)
//     {
//       // Введите свое решение ниже
//        if (results[0] != 0){
//           System.Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//       } else {
//           System.Console.WriteLine("There is no such index");
//         }
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int n, m, k, x, y;

//         if (args.Length >= 5) {
//            n = int.Parse(args[0]);
//            m = int.Parse(args[1]);
//            k = int.Parse(args[2]);
//            x = int.Parse(args[3]);
//            y = int.Parse(args[4]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            n = 3;
//            m = 4;
//            k = 2;
//            x = 2;
//            y = 3;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
//     }
// }










// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом 
// увеличивающимся на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, 
// m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает 
// матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив 
// типа double. Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и 
// сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот 
// список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 - это значения 
// средних значений столбцов, округленные до двух знаков после запятой (в дробной части ВСЕГДА должно 
// быть 2 числа через точку, см. формат вывода), разделенные знаком табуляции.

// Пример

// n = 3;
// m = 4;
// k = 2;

// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintListAvr(FindAverageInColumns(result));

// /*
// 1   3   5   7   
// 9   11  13  15  
// 17  19  21  23  
// The averages in columns are:
// 9.00    11.00   13.00   15.00
// */

// Решение

// using System; 
 
// public class Answer { 
//     public static void PrintArray (int [,] matrix) 
//     { 
//         for (int i=0; i<matrix.GetLength(0); i++) 
//         { 
//             for (int j=0; j<matrix.GetLength(1);j++) 
//             { 
//                 Console.Write($"{matrix[i,j]}"+"\t"); 
//             } 
//             Console.WriteLine(); 
//         } 
//     } 
 
//     public static int[,] CreateIncreasingMatrix(int n, int m, int k) 
//     { 
//         int[,] newMatrix = new int[n,m]; 
//         int currentValue = 1; 
//         for (int i=0; i<n; i++) 
//         { 
//             for (int j=0; j<m; j++) 
//             { 
//                 newMatrix[i,j] = currentValue; 
//                 currentValue += k; 
//             } 
//         } 
//         return newMatrix; 
//     } 
 
//     static void PrintListAvr (double [] list) 
//     { 
//         Console.WriteLine("The averages in columns are:"); 
//         foreach (double el in list) 
//         { 
//             Console.Write($"{el:f2}"+"\t"); 
 
//         } 
//         Console.WriteLine(); 
//     } 
 
//     static double [] FindAverageInColumns (int [,] matrix) 
//     {  
//         double runningSum=0; 
//         double [] columns = new double [matrix.GetLength(1)]; 
//         for (int j=0; j<matrix.GetLength(1);j++) 
//         { 
//             runningSum=0; 
//             for (int i=0; i<matrix.GetLength(0);i++) 
//             { 
//                 runningSum=runningSum+matrix[i,j]; 
//             } 
//             columns[j]=runningSum/matrix.GetLength(0); 
//         } 
//         return columns; 
//     } 
 
 
//     // Не удаляйте и не меняйте метод Main!  
//     static public void Main(string[] args) { 
//         int n, m, k; 
 
//         if (args.Length >= 3) { 
//            n = int.Parse(args[0]); 
//            m = int.Parse(args[1]); 
//            k = int.Parse(args[2]); 
//         } else { 
//            // Здесь вы можете поменять значения для отправки кода на Выполнение 
//            n = 3; 
//            m = 4; 
//            k = 2; 
//         } 
 
//         // Не удаляйте строки ниже 
//         int[,] result = CreateIncreasingMatrix(n, m, k); 
//         PrintArray(result); 
//         PrintListAvr(FindAverageInColumns(result)); 
//     } 
// }