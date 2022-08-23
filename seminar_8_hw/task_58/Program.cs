/* 
Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
*/

Console.Write("Введите число для 1-ой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
Console.Write("Введите число для 2-ой матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());
int b = p;

Console.WriteLine("Двумерный массив №1: ");
int[,] firstMatrix = new int[m, n];
getArray(firstMatrix);
printArray(firstMatrix);

Console.WriteLine("Двумерный массив №2: ");
int[,] secondMatrix = new int[p, b];
getArray(secondMatrix);
printArray(secondMatrix);

void getArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(10);
        }
    }
}

void printArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

multiMatrix(firstMatrix, secondMatrix);
Console.WriteLine("Произведение двух матриц: ");
printArray(firstMatrix);

void multiMatrix(int[,] firstMatrix, int[,] secondMatrix) {
    for (int i = 0; i < firstMatrix.GetLength(0); i++) {
        for (int j = 0; j < secondMatrix.GetLength(1); j++) {
            firstMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
        }
    }
}
