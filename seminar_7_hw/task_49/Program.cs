//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = getArray(rows, columns, 0, 10);
printArray(array);
Console.WriteLine();
printArray(result(array));

int[,] getArray(int m, int n, int min, int max) {
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            result[i, j] = new Random().Next(min, max + 1);
            }
        }
        return result;
}
int[,] result(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            if (i % 2 == 0 && j % 2 == 0) {
                array[i, j] *= array[i, j];
                }
            }
        }
        return array;
}

void printArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}