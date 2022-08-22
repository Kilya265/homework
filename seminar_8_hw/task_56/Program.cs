/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/

Console.Write("Введите число: ");
int row = Convert.ToInt32(Console.ReadLine());
int col = row;

Console.WriteLine("Прямоугольный двумерный массив: ");

int[,] array = new int[row, col];
getArray(array);
printArray(array);

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

int minSumRow = 0;
int sumRow = sumRowElement(array, 0);
for (int i = 1; i < array.GetLength(0); i++) {
    int tempsumRow = sumRowElement(array, i);
    if (sumRow > tempsumRow) {
        sumRow = tempsumRow;
        minSumRow = i;
    }
}

Console.WriteLine("Строкa с наименьшей суммой (" + sumRow + ") элементов № " + minSumRow);

int sumRowElement(int[,] array, int i) {
    int sumRow = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++) {
        sumRow += array[i,j];
    }
    return sumRow;
}
