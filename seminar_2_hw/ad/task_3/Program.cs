// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int div_7 = number % 7;
int div_23 = number % 23;

Console.WriteLine($"\nКратно ли число {number} одновременно 7 и 23?");

if ((div_7 == 0) && (div_23 == 0)) Console.WriteLine("да");
else Console.WriteLine("нет");