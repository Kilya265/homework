/*
Задайте двумерный массив. Напишите программу, которая упорядочит по
убыванию элементы каждой строки двумерного массива.
*/

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine());

int[,] array = new int[row, col];
getArray(array);
printArray(array);

void getArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(1, 50);
        }
    }
}

Console.WriteLine("Отсортированный массив: ");
sort(array);
printArray(array);

void sort(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(1) - 1; k++) {
                if (array[i, k] > array[i, k + 1]) {
                    int temp = array[i, k] ;
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
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
