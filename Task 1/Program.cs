// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

 int[,] array = new int[4, 4];
 FillArray(array);
 PrintArray(array);
 Console.WriteLine();
 SortArray(array);
 PrintArray(array);

void FillArray(int[,] arr)
 {
     for (int m = 0; m < arr.GetLength(0); m++)
     {
         for (int n = 0; n < arr.GetLength(1); n++)
         {
             arr[m, n] = new Random().Next(-10, 10);
         }
     }
 }

void PrintArray(int[,] arr)
 {
     for (int m = 0; m < arr.GetLength(0); m++)
     {
         for (int n = 0; n < arr.GetLength(1); n++)
         {
             Console.Write($"{arr[m, n]}|");
         }
         Console.WriteLine();
     }
 }
 
void SortArray(int[,] arr)
 {
     for (int m = 0; m < arr.GetLength(0); m++)
     {
         for (int n = 0; n < arr.GetLength(1); n++)
         {
             for (int k = 0; k < arr.GetLength(1) - n - 1; k++)
             {
                 if (arr[m, k] < arr[m, k + 1])
                 {
                     int t = arr[m, k];
                     arr[m, k] = arr[m, k + 1];
                     arr[m, k + 1] = t;
                 }
             }
         }
     }
 }