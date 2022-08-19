//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
Console.Write("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array(int m, int n) {
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = new Random().Next(1, 50);
        }
    }
    return matrix;
}
int[,] resultMatrix = array(m, n);

void printArray(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
printArray(resultMatrix);
Console.WriteLine("\n" + "Среднеe арифметическое для столбцов: ");
int[] summ = new int[n];
for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        summ[j] += resultMatrix[i, j]; 
    }
}
foreach (double elem in summ) {
    Console.Write(elem/m + " \t");
}
Console.WriteLine();
