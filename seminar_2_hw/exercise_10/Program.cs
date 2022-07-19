// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
string number = Console.ReadLine();

if (number.Length > 2) Console.WriteLine(number[1]);
else Console.WriteLine("Введено не трёхзначное число");