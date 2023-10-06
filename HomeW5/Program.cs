// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int [] CreateRandomArray(int min, int max, int size){
//     int [] array = new int [size];
//     for (int i = 0; i<size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for(int i = 0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SumEvenNum(int [] array){
//     int sumOfNum = 0;
//     for (int i = 0; i < array.Length; i++){
//         if (array [i] > 99 && array [i] < 1000){
//             if (array [i] % 2 == 0){
//                 sumOfNum++;
//             }
//         }
//         else{
//             Console.WriteLine("Wrong number");
//         }
//     }
//     Console.Write($"Quantity of 3 char positive even numbers is {sumOfNum}");
// }


// Console.WriteLine("Enter min 3 char positive number of array val:");
// int min = Convert.ToInt32(Console.ReadLine());
// // if (min < 99 || min > 999){
// //     Console.WriteLine("Wrong number");
// // }
// Console.WriteLine("Enter max 3 char positive number of array val:");
// int max = Convert.ToInt32(Console.ReadLine());
// // if (max < 99 || max > 999){
// //     Console.WriteLine("Wrong number");
// // }
// Console.WriteLine("Enter size of array:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(min,max,size);
// ShowArray(newArray);
// SumEvenNum(newArray);








// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] CreateRandomArray(int min, int max, int size){
//     int [] array = new int [size];
//     for (int i = 0; i<size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for(int i = 0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SumNotEvenIndexNum(int [] array){
//     int res = 0;
//     for (int i = 1; i < array.Length; i += 2){
//         res = res + array [i];
        
//     }
//     Console.WriteLine($"Sum of not even index num is: {res}");
// }


// Console.WriteLine("Enter min of array val:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max of array val:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(min,max,size);
// ShowArray(newArray);
// SumNotEvenIndexNum(newArray);









// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double [] array = {4.50, 16.20, 20.55, 11.01, 2.60, 80.05, 17.99, 40.02};

// void ShowArray(double [] array){
//     for(int i = 0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SortArray(double [] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = 0; j < array.Length - i - 1; j++)
//         {
//             if (array [j]> array [j+1]){
//                 double sort = array [j];
//                 array [j] = array [j+1];
//                 array [j+1] = sort;

//             }
//         }
//     }
//     Console.WriteLine($"Diff between max and min is: {array[array.Length - 1] - array [0]}");
// }


// ShowArray(array);
// SortArray(array);
