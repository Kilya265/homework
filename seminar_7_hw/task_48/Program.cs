//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
//Выведите полученный массив на экран.
Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array(int m, int n) {
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = i + j; 
        }
    }
    return matrix;
}

int[,] resultMatrix = array(rows, columns);

void printArray(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
printArray(resultMatrix);
