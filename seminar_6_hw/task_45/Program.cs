//Напишите программу, которая будет создавать копию
//заданного массива с помощью поэлементного копирования.

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
int[] arrayCopy = new int[n];

Console.WriteLine("Массив: ");
for (int i = 0; i < n; i++) {
    array[i] = new Random().Next(-10, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Копия заданного массива: ");
for (int j = 0; j < n; j++) {
    arrayCopy[j] = array[j];
    Console.Write(arrayCopy[j] + " ");
}
Console.WriteLine();
