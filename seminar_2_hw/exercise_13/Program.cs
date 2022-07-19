// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
string number = Console.ReadLine();

if (number.Length > 2) Console.WriteLine(number[2]);
else Console.WriteLine("Третьей цифры нет");
