using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_m4 {
    internal class Program {
        static void Main(string[] args) {

            Random r = new Random();

            Console.Write("Введите кол-во строк: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите кол-во столбцов: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] matrixA = new int[a, b];
            int[,] matrixB = new int[a, b];
            int[,] matrixC = new int[a, b];

            int matrixFirstSum = 0;

            //Заполнить и вывести матрицу А
            Console.WriteLine($"matrixA:");
            for (int i = 0; i < matrixA.GetLength(0); i++) {
                for (int j = 0; j < matrixA.GetLength(1); j++) {
                    matrixA[i, j] = r.Next(10);
                    matrixFirstSum += matrixA[i, j]; 
                    Console.Write ($"{matrixA[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов matrixA: {matrixFirstSum}");

            Console.WriteLine();

            //Заполнить и вывести матрицу Б
            Console.WriteLine($"matrixB:");
            for (int i = 0; i < matrixB.GetLength(0); i++) {
                for (int j = 0; j < matrixB.GetLength(1); j++) {
                    matrixB[i, j] = r.Next(10);
                    Console.Write($"{matrixB[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Сложение матриц A и B, вывести на экран результат в матрице C
            Console.WriteLine($"matrixC:");
            for(int i = 0;i < matrixC.GetLength(0);i++) {
                for(int j = 0;j < matrixC.GetLength(1);j++) {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                    Console.Write($"{matrixC[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
