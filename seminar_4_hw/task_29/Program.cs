//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

var r = new Random();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++){
    array[i] = r.Next(0,50);
}
Console.Write("Массив: [");
foreach (int i in array)
Console.Write($"{i},");
Console.WriteLine("]");
