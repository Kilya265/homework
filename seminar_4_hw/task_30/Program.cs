// See https://aka.ms/new-console-template for more information

var r = new Random();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++){
    array[i] = r.Next(0,2);
}
Console.Write("Массив: [");
foreach (int i in array)
Console.Write($"{i},");
Console.WriteLine("]");
