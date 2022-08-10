//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++) {
    array[i] = rand.Next(100) + Math.Round(rand.NextDouble(), 2);
    Console.WriteLine(array[i] + " ");
}

double min = array[0];
double max = 0;
double count = 0;

foreach (double j in array) {
    if (min > j) min = j;
    if (max < j) max = j;
    count = Math.Round((max - min),2);
}

Console.WriteLine("Разница между "+ max + " и " + min + " равна " + count);
