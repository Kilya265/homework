// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine());

int[,] array = new int[row, col];

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

getArray(array);
PrintArray(array);

int first = num / 10;
int second = num % 10;
Console.WriteLine();
if (first < col && second < row) Console.WriteLine($"На позиции \"{num}\" находится число: {array[first, second]}");
else Console.WriteLine("Такого элемента нет");

void getArray(int[,] array) {
    for (int m = 0; m < array.GetLength(0); m++) {
        for (int n = 0; n < array.GetLength(1); n++) {
            array[m, n] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] array) {
    for (int m = 0; m < array.GetLength(0); m++) {
        for (int n = 0; n < array.GetLength(1); n++) {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
