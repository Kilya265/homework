//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array(int m, int n, int min, int max) {
    int[,] matrix = new int [m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
return matrix;
}

int[,] resultMatrix = array(rows, columns, 0, 10);
PrintArray(resultMatrix);

void PrintArray(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
