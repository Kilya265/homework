// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int multiple = Convert.ToInt32(Console.ReadLine());
int result = number % multiple;

if (result == 0) Console.WriteLine("кратно");
else Console.WriteLine($"не кратно, остаток {result}");