// Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

Console.WriteLine("Введите число, которое необходимо найти: ");
int count = 0;
int [] array = new int[5];
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(0, 20);
    Console.Write(array[i] + " ");
}

foreach (var item in array) {
    if (item == num) count = 1;
}

if (count > 0) Console.WriteLine("-> да");
else Console.WriteLine("-> нет");
